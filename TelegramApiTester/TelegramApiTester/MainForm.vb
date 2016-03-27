'*********************************************************************************************
'*  Author: Gr0wlit                                                                          *   
'*  Release Date: 24/12/2015                                                                 *
'*  Version: 1.0                                                                             *
'*                                                                                           *
'*  This project is open souce, everyone can use it or implement                             *
'*  it in his own projects. Please, if you can, leave credits.                               *
'*                                                                                           *
'*  Everything here can be improved: please, if you can improve my code,                     *
'*  post it on my thread, I will implement it and I will give credits.                       *
'*                                                                                           *
'*                                                                                           *
'*  IMPROVEMENTS                                                                             *
'* - 25/12/2015: Deserializing TelegramObject inside the constructor                         *
'*               (Thanks to Programming Enthousiast)                                         *
'*                                                                                           *
'* Sorry for my bad english!                                                                 *
'*********************************************************************************************

Imports System.Web.Script.Serialization
Imports System.Net

Public Class MainForm
    Private _TOKEN As String
    Private _FILEPATH As String

#Region "Toolbar"

    Private Sub tsmiToken_Click(sender As Object, e As EventArgs) Handles tsmiToken.Click
        Try
            'Get the token
            Dim st As New frmToken
            If st.ShowDialog = Windows.Forms.DialogResult.OK _
                AndAlso Not String.IsNullOrEmpty(st.txtToken.Text) _
                AndAlso st.txtToken.Text.Length < 200 Then
                _TOKEN = st.txtToken.Text
                lblToken.Text = _TOKEN
                pnlMain.Enabled = True

                'Token loaded, load details about the bot...
                'Create an instance of a webclient that will download the JSON string of the informations about the bot
                Dim wc As New WebClient
                AddHandler wc.DownloadStringCompleted, AddressOf GetMe
                Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/getme", _TOKEN)
                wc.DownloadStringAsync(New Uri(sURL))

            Else
                pnlMain.Enabled = False
            End If
        Catch ex As Exception
            'This is just a simple handling
            MessageBox.Show(String.Format("An error of type {0} occurred!{1}{2}", ex.GetType.ToString, vbCrLf, ex.Message), _
                            ex.GetType.ToString, _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsmiFilePath_Click(sender As Object, e As EventArgs) Handles tsmiFilePath.Click
        Try
            Dim fbd As New FolderBrowserDialog

            fbd.Description = "Choose where to save each file"
            If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
                _FILEPATH = fbd.SelectedPath
                lblFilePath.Text = fbd.SelectedPath
            End If

        Catch ex As Exception
            'This is just a simple handling
            MessageBox.Show(String.Format("An error of type {0} occurred!{1}{2}", ex.GetType.ToString, vbCrLf, ex.Message), _
                            ex.GetType.ToString, _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "GetMe"

    Private Sub GetMe(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
            Dim User As New User
            User.Map(JSONobj.result)


            'Now we have an User object, let's populate the info
            If Not User Is Nothing Then
                lblID.Text = User.id
                lblFName.Text = User.first_name
                lblLName.Text = User.last_name
                lblUsername.Text = User.username
            Else
                MessageBox.Show("The JSON object returned from server is null!", _
                                "Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            'Clear the groupbox and disable the panel
            lblID.Text = "-"
            lblLName.Text = "-"
            lblFName.Text = "-"
            lblUsername.Text = "-"
            pnlMain.Enabled = False

            SimpleExceptionHandling(ex)
        End Try
    End Sub

#End Region

#Region "Updates"

    Private Sub btnGetUpdates_Click(sender As Object, e As EventArgs) Handles btnGetUpdates.Click
        Try
            'Clear details about last update
            lblMessageType.Text = String.Empty
            lblFrom.Text = String.Empty
            lblChatID.Text = String.Empty
            lblDate.Text = String.Empty
            txtText.Text = String.Empty
            lblIDMsg.Text = String.Empty

            'Create an instance of a webclient that will download the JSON string of the informations about the bot
            Dim wc As New WebClient
            AddHandler wc.DownloadStringCompleted, AddressOf GetUpdates
            Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/getupdates", _TOKEN)
            wc.DownloadStringAsync(New Uri(sURL))
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private _Updates As List(Of Update)
    Private _CurrentUpdate As Update
    Private Sub GetUpdates(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Clear the listbox and reinstanciate the list
            _Updates = New List(Of Update)
            lstUpdates.Items.Clear()

            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
            For i As Integer = 0 To CType(JSONobj.result, Object()).Count - 1
                'Add each update to the list and write the ID into the listbox
                Dim upd As New Update
                upd.Map(JSONobj.result(i))
                lstUpdates.Items.Add(upd.update_id)
                _Updates.Add(upd)
            Next
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try

    End Sub

    Private Sub lstUpdates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUpdates.SelectedIndexChanged
        If lstUpdates.SelectedItems.Count > 0 Then
            Try
                _CurrentUpdate = New Update

                'If found, assign the current update object to the _CurrentUpdate variable
                _CurrentUpdate = _Updates.Where(Function(upd As Update) upd.update_id = lstUpdates.SelectedItem.ToString).ToList.Item(0)

                If Not _CurrentUpdate Is Nothing Then
                    With _CurrentUpdate
                        'Getting the message type (photo, sticker etc..)
                        lblMessageType.Text = [Enum].GetName(GetType(Message.MessageType), .message.GetMessageType)
                        'Getting other details..
                        lblIDMsg.Text = .message.message_id
                        lblFrom.Text = .message.from.username
                        lblChatID.Text = .message.chat.id
                        'Convert from UNIX time
                        lblDate.Text = New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(.message._date).ToLocalTime().ToString
                        txtText.Text = .message.text
                    End With
                End If
            Catch ex As Exception
                SimpleExceptionHandling(ex)
            End Try
        End If
    End Sub

    Dim _cmnu As ContextMenuStrip
    Private Sub lblMessageType_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMessageType.LinkClicked
        Try
            'Creating at runtime a new contextmenustrip depending on the message type
            _cmnu = New ContextMenuStrip
            Select Case _CurrentUpdate.message.GetMessageType
                Case Message.MessageType.Photo
                    For i As Integer = 0 To _CurrentUpdate.message.photo.Count - 1
                        Dim mnuitem As New ToolStripMenuItem
                        mnuitem.Text = String.Format("Download photo {0}x{1} ({2}Kb)", _CurrentUpdate.message.photo(i).width, _CurrentUpdate.message.photo(i).height, _CurrentUpdate.message.photo(i).file_size / 1000)
                        mnuitem.Tag = _CurrentUpdate.message.photo(i).file_id
                        AddHandler (mnuitem.Click), AddressOf mnuDownload
                        _cmnu.Items.Add(mnuitem)

                        Dim mnuID As New ToolStripMenuItem
                        mnuID.Text = "Copy ID of this item"
                        AddHandler (mnuID.Click), AddressOf mnuCopy
                        mnuID.Tag = _CurrentUpdate.message.photo(i).file_id
                        _cmnu.Items.Add(mnuID)
                    Next


                Case Message.MessageType.Sticker
                    Dim mnuitemSticker As New ToolStripMenuItem
                    mnuitemSticker.Text = String.Format("Download sticker {0}x{1} ({2}Kb)", _CurrentUpdate.message.sticker.width, _CurrentUpdate.message.sticker.height, _CurrentUpdate.message.sticker.file_size / 1000)
                    mnuitemSticker.Tag = _CurrentUpdate.message.sticker.file_id
                    AddHandler (mnuitemSticker.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitemSticker)

                    Dim mnuitemThumb As New ToolStripMenuItem
                    mnuitemThumb.Text = String.Format("Download thumb {0}x{1} ({2}Kb)", _CurrentUpdate.message.sticker.thumb.width, _CurrentUpdate.message.sticker.thumb.height, _CurrentUpdate.message.sticker.thumb.file_size / 1000)
                    mnuitemThumb.Tag = _CurrentUpdate.message.sticker.file_id
                    AddHandler (mnuitemThumb.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitemThumb)

                    Dim mnuID As New ToolStripMenuItem
                    mnuID.Text = "Copy ID of this item"
                    AddHandler (mnuID.Click), AddressOf mnuCopy
                    mnuID.Tag = _CurrentUpdate.message.sticker.thumb.file_id
                    _cmnu.Items.Add(mnuID)


                Case Message.MessageType.Audio
                    Dim mnuitem As New ToolStripMenuItem
                    mnuitem.Text = String.Format("Download audio ({0} sec. - {1}Kb)", _CurrentUpdate.message.audio.duration, _CurrentUpdate.message.audio.file_size / 1000)
                    mnuitem.Tag = _CurrentUpdate.message.audio.file_id
                    AddHandler (mnuitem.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitem)

                    Dim mnuID As New ToolStripMenuItem
                    mnuID.Text = "Copy ID of this item"
                    AddHandler (mnuID.Click), AddressOf mnuCopy
                    mnuID.Tag = _CurrentUpdate.message.sticker.thumb.file_id
                    _cmnu.Items.Add(mnuID)


                Case Message.MessageType.Voice
                    Dim mnuitem As New ToolStripMenuItem
                    mnuitem.Text = String.Format("Download voice ({0}Kb)", _CurrentUpdate.message.voice.file_size / 1000)
                    mnuitem.Tag = _CurrentUpdate.message.voice.file_id
                    AddHandler (mnuitem.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitem)

                    Dim mnuID As New ToolStripMenuItem
                    mnuID.Text = "Copy ID of this item"
                    AddHandler (mnuID.Click), AddressOf mnuCopy
                    mnuID.Tag = _CurrentUpdate.message.voice.file_id
                    _cmnu.Items.Add(mnuID)


                Case Message.MessageType.Contact
                    Dim mnuitem As New ToolStripMenuItem
                    mnuitem.Text = String.Format("Copy contact '{0}' ({1})", _CurrentUpdate.message.contact.first_name, _CurrentUpdate.message.contact.phone_number)
                    mnuitem.Tag = _CurrentUpdate.message.contact.phone_number
                    AddHandler (mnuitem.Click), AddressOf mnuCopy
                    _cmnu.Items.Add(mnuitem)



                Case Message.MessageType.Document
                    Dim mnuitem As New ToolStripMenuItem
                    mnuitem.Text = String.Format("Download document '{0}' ({1}Kb)", _CurrentUpdate.message.document.file_name, _CurrentUpdate.message.document.file_size / 1000)
                    mnuitem.Tag = _CurrentUpdate.message.document.file_id
                    AddHandler (mnuitem.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitem)

                    Dim mnuitemThumb As New ToolStripMenuItem
                    mnuitemThumb.Text = String.Format("Download thumb {0}x{1} ({2}Kb)", _CurrentUpdate.message.document.thumb.width, _CurrentUpdate.message.document.thumb.height, _CurrentUpdate.message.document.thumb.file_size / 1000)
                    mnuitemThumb.Tag = _CurrentUpdate.message.document.file_id
                    AddHandler (mnuitemThumb.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitemThumb)

                    Dim mnuID As New ToolStripMenuItem
                    mnuID.Text = "Copy ID of this item"
                    AddHandler (mnuID.Click), AddressOf mnuCopy
                    mnuID.Tag = _CurrentUpdate.message.document.file_id
                    _cmnu.Items.Add(mnuID)


                Case Message.MessageType.Video
                    Dim mnuitem As New ToolStripMenuItem
                    mnuitem.Text = String.Format("Download video {0}x{1} ({2}sec. - {3}Kb)", _CurrentUpdate.message.video.width, _CurrentUpdate.message.video.height, _CurrentUpdate.message.video.duration, _CurrentUpdate.message.video.file_size / 1000)
                    mnuitem.Tag = _CurrentUpdate.message.video.file_id
                    AddHandler (mnuitem.Click), AddressOf mnuDownload
                    _cmnu.Items.Add(mnuitem)

                    Dim mnuID As New ToolStripMenuItem
                    mnuID.Text = "Copy ID of this item"
                    AddHandler (mnuID.Click), AddressOf mnuCopy
                    mnuID.Tag = _CurrentUpdate.message.video.file_id
                    _cmnu.Items.Add(mnuID)

            End Select
            If Not _cmnu Is Nothing Then _cmnu.Show(lblMessageType.PointToScreen(Point.Empty))
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub mnuCopy(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(CType(sender, ToolStripMenuItem).Tag.ToString)
            'Do what you want here
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub mnuDownload(ByVal sender As Object, ByVal e As EventArgs)
        Try
            'In the TAG property of the sender we have the file_ID to be downloaded. So through the GetFile method we can have the path of the file to download

            'Create an instance of a webclient that will download the path of the file to download
            Dim wc As New WebClient
            AddHandler wc.DownloadStringCompleted, AddressOf GetFile
            Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/getfile?file_id={1}", _TOKEN, CType(sender, ToolStripMenuItem).Tag)
            wc.DownloadStringAsync(New Uri(sURL))

        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private _FILEPATHDOWNLOADED As String
    Private Sub GetFile(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
            Dim File As New File
            File.Map(JSONobj.result)  'Now we have the file object with its property "file_path", that it's where we can download the file

            'Create an instance of a webclient that will download the path of the file to download
            Dim wc As New WebClient
            AddHandler wc.DownloadFileCompleted, AddressOf FileDownloaded
            Dim sURL As String = String.Format("https://api.telegram.org/file/bot{0}/{1}", _TOKEN, File.file_path)
            _FILEPATHDOWNLOADED = _FILEPATH & File.file_path.Split("/")(1) 'Uhm yes, it can be improved :D
            wc.DownloadFileAsync(New Uri(sURL), _FILEPATHDOWNLOADED)

        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try

    End Sub

    Private Sub FileDownloaded(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Try
            If MessageBox.Show("File downloaded, would you like to open it?", "Downloaded", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Process.Start(_FILEPATHDOWNLOADED)
            End If
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub lblFrom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFrom.LinkClicked
        Try
            _cmnu = New ContextMenuStrip
            Dim mnuitem As New ToolStripMenuItem
            mnuitem.Text = String.Format("Copy user's ID ({0})", _CurrentUpdate.message.from.id)
            mnuitem.Tag = _CurrentUpdate.message.from.id
            AddHandler (mnuitem.Click), AddressOf mnuCopy
            _cmnu.Items.Add(mnuitem)
            If Not _cmnu Is Nothing Then _cmnu.Show(lblFrom.PointToScreen(Point.Empty))
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub lblChatID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChatID.LinkClicked
        Try
            _cmnu = New ContextMenuStrip
            Dim mnuitem As New ToolStripMenuItem
            mnuitem.Text = String.Format("Copy chat's ID ({0})", _CurrentUpdate.message.chat.id)
            mnuitem.Tag = _CurrentUpdate.message.chat.id
            AddHandler (mnuitem.Click), AddressOf mnuCopy
            _cmnu.Items.Add(mnuitem)
            If Not _cmnu Is Nothing Then _cmnu.Show(lblFrom.PointToScreen(Point.Empty))
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

#End Region

#Region "Send"

    Private Sub btnSendChatAction_Click(sender As Object, e As EventArgs) Handles btnSendChatAction.Click
        Try
            If Not String.IsNullOrEmpty(txtChatID.Text) Then
                Dim wc As New WebClient
                AddHandler wc.DownloadStringCompleted, AddressOf SendChatAction
                Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/sendChatAction?chat_id={1}&action={2}", _TOKEN, txtChatID.Text, cboSendAction.Text)
                wc.DownloadStringAsync(New Uri(sURL))
            End If
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub SendChatAction(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
            'Chat action sent: do what you want here

        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click
        Try
            If Not String.IsNullOrEmpty(txtChatID.Text) Then
                Dim wc As New WebClient
                AddHandler wc.DownloadStringCompleted, AddressOf SendText
                Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}", _TOKEN, txtChatID.Text, txtSendText.Text)
                If Not String.IsNullOrEmpty(txtIDMessageReply.Text.Trim) AndAlso chkReplyToMessage.Checked Then
                    sURL &= String.Format("&reply_to_message_id={0}", txtIDMessageReply.Text)
                End If
                wc.DownloadStringAsync(New Uri(sURL))
            End If
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub SendText(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
                'Here you can map the result as a message. It means that you sent the message correctly

        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub chkReplyToMessage_CheckedChanged(sender As Object, e As EventArgs) Handles chkReplyToMessage.CheckedChanged
        If chkReplyToMessage.Checked Then
            txtIDMessageReply.Enabled = True
        Else
            txtIDMessageReply.Text = String.Empty
            txtIDMessageReply.Enabled = False
        End If
    End Sub

#End Region

#Region "Forward"

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Try
            If Not String.IsNullOrEmpty(txtForwardFromChatID.Text) AndAlso _
               Not String.IsNullOrEmpty(txtForwardMessageID.Text) Then
                Dim wc As New WebClient
                AddHandler wc.DownloadStringCompleted, AddressOf ForwardMessage
                Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/forwardMessage?chat_id={1}&from_chat_id={2}&message_id={3}", _TOKEN, txtChatID.Text, txtForwardFromChatID.Text, txtForwardMessageID.Text)
                wc.DownloadStringAsync(New Uri(sURL))
            End If
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub ForwardMessage(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
            'Here you can map the result as a message. It means that you forwarded the message correctly

        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

#End Region

#Region "SendItem"

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim sURL As String = String.Format("https://api.telegram.org/bot{0}/", _TOKEN)

            If rbAudio.Checked Then
                sURL &= String.Format("sendAudio?chat_id={0}&audio={1}", txtChatID.Text, txtSendItemID.Text)
            ElseIf rbDocument.Checked Then
                sURL &= String.Format("sendDocument?chat_id={0}&document={1}", txtChatID.Text, txtSendItemID.Text)
            ElseIf rbPhoto.Checked Then
                sURL &= String.Format("sendPhoto?chat_id={0}&photo={1}", txtChatID.Text, txtSendItemID.Text)
            ElseIf rbSticker.Checked Then
                sURL &= String.Format("sendSticker?chat_id={0}&sticker={1}", txtChatID.Text, txtSendItemID.Text)
            ElseIf rbVideo.Checked Then
                sURL &= String.Format("sendVideo?chat_id={0}&video={1}", txtChatID.Text, txtSendItemID.Text)
            ElseIf rbVoice.Checked Then
                sURL &= String.Format("sendVoice?chat_id={0}&voice={1}", txtChatID.Text, txtSendItemID.Text)
            End If

            'Create an instance of a webclient that will download the JSON string of the informations about the bot
            Dim wc As New WebClient
            AddHandler wc.DownloadStringCompleted, AddressOf SendItem
            wc.DownloadStringAsync(New Uri(sURL))
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

    Private Sub SendItem(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            'Here we deserialize the JSON object returned from server into a generic Telegram object
            Dim JSONobj As New TelegramObject(e.Result)
                'Here you can map the result as a message. It means that you forwarded the message correctly
           
        Catch ex As Exception
            SimpleExceptionHandling(ex)
        End Try
    End Sub

#End Region

#Region "Uncategorized methods"

    Private Sub txtSendChatID_TextChanged(sender As Object, e As EventArgs) Handles txtChatID.TextChanged
        If txtChatID.Text.Length > 0 Then
            gbSend.Enabled = True
            gbForward.Enabled = True
            gbSendItem.Enabled = True
        Else
            gbSend.Enabled = False
            gbForward.Enabled = False
            gbSendItem.Enabled = False
        End If
    End Sub

    Private Sub SimpleExceptionHandling(ByVal ex As Exception)
        Try
            'If the innerexception is a webexception, I can get the details about the error from the properties of the telegramObject
            If Not TryCast(ex.InnerException, WebException) Is Nothing Then
                Dim sResponse As String = New IO.StreamReader(CType(ex.InnerException, WebException).Response.GetResponseStream()).ReadToEnd
                Dim JSONobj As New TelegramObject(sResponse)
                MessageBox.Show(String.Format("The object returned from server is not 'OK'.{0}Error code: {1}{2}Description: {3}", vbCrLf, JSONobj.error_code, vbCrLf, JSONobj.description), _
                                "Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)

            Else
                'This is just a simple handling in case of others kind of exceptions
                MessageBox.Show(String.Format("An error of type {0} occurred!{1}{2}", ex.GetType.ToString, vbCrLf, ex.Message), _
                                ex.GetType.ToString, _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
            End If
        Catch e As Exception
            'Try catch inside method called by another catch?
            MessageBox.Show(String.Format("An error of type {0} occurred!{1}{2}", e.GetType.ToString, vbCrLf, e.Message), _
                                e.GetType.ToString, _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
        End Try

    End Sub

#End Region



End Class
