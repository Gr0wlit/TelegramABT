<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiToken = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFilePath = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblSendChatInfoID = New System.Windows.Forms.Label()
        Me.txtChatID = New System.Windows.Forms.TextBox()
        Me.gbSendItem = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblSendItemID = New System.Windows.Forms.Label()
        Me.txtSendItemID = New System.Windows.Forms.TextBox()
        Me.rbVoice = New System.Windows.Forms.RadioButton()
        Me.rbVideo = New System.Windows.Forms.RadioButton()
        Me.rbSticker = New System.Windows.Forms.RadioButton()
        Me.rbDocument = New System.Windows.Forms.RadioButton()
        Me.rbAudio = New System.Windows.Forms.RadioButton()
        Me.rbPhoto = New System.Windows.Forms.RadioButton()
        Me.gbForward = New System.Windows.Forms.GroupBox()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.lblForwardMessageID = New System.Windows.Forms.Label()
        Me.txtForwardMessageID = New System.Windows.Forms.TextBox()
        Me.lblFromChatID = New System.Windows.Forms.Label()
        Me.txtForwardFromChatID = New System.Windows.Forms.TextBox()
        Me.gbSend = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDMessageReply = New System.Windows.Forms.TextBox()
        Me.chkReplyToMessage = New System.Windows.Forms.CheckBox()
        Me.cboSendAction = New System.Windows.Forms.ComboBox()
        Me.btnSendChatAction = New System.Windows.Forms.Button()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.lbLSendInfoText = New System.Windows.Forms.Label()
        Me.txtSendText = New System.Windows.Forms.TextBox()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.lblInfoFilePath = New System.Windows.Forms.Label()
        Me.gbPreview = New System.Windows.Forms.GroupBox()
        Me.lblIDMsg = New System.Windows.Forms.Label()
        Me.lblInfoIDMsg = New System.Windows.Forms.Label()
        Me.lblInfoText = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblInfoDate = New System.Windows.Forms.Label()
        Me.lblChatID = New System.Windows.Forms.LinkLabel()
        Me.lblInfoChat = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.LinkLabel()
        Me.lblInfoFrom = New System.Windows.Forms.Label()
        Me.lblMessageType = New System.Windows.Forms.LinkLabel()
        Me.lblInfoMessageType = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lstUpdates = New System.Windows.Forms.ListBox()
        Me.btnGetUpdates = New System.Windows.Forms.Button()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.lblInfoToken = New System.Windows.Forms.Label()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblInfoUsername = New System.Windows.Forms.Label()
        Me.lblInfoLName = New System.Windows.Forms.Label()
        Me.lblInfoFName = New System.Windows.Forms.Label()
        Me.lblInfoID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MainMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.gbSendItem.SuspendLayout()
        Me.gbForward.SuspendLayout()
        Me.gbSend.SuspendLayout()
        Me.gbPreview.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(708, 24)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSet})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiSet
        '
        Me.tsmiSet.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiToken, Me.tsmiFilePath})
        Me.tsmiSet.Name = "tsmiSet"
        Me.tsmiSet.Size = New System.Drawing.Size(90, 22)
        Me.tsmiSet.Text = "Set"
        '
        'tsmiToken
        '
        Me.tsmiToken.Name = "tsmiToken"
        Me.tsmiToken.Size = New System.Drawing.Size(119, 22)
        Me.tsmiToken.Text = "Token"
        '
        'tsmiFilePath
        '
        Me.tsmiFilePath.Name = "tsmiFilePath"
        Me.tsmiFilePath.Size = New System.Drawing.Size(119, 22)
        Me.tsmiFilePath.Text = "File Path"
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Controls.Add(Me.lblSendChatInfoID)
        Me.pnlMain.Controls.Add(Me.txtChatID)
        Me.pnlMain.Controls.Add(Me.gbSendItem)
        Me.pnlMain.Controls.Add(Me.gbForward)
        Me.pnlMain.Controls.Add(Me.gbSend)
        Me.pnlMain.Controls.Add(Me.lblFilePath)
        Me.pnlMain.Controls.Add(Me.lblInfoFilePath)
        Me.pnlMain.Controls.Add(Me.gbPreview)
        Me.pnlMain.Controls.Add(Me.lstUpdates)
        Me.pnlMain.Controls.Add(Me.btnGetUpdates)
        Me.pnlMain.Controls.Add(Me.lblToken)
        Me.pnlMain.Controls.Add(Me.lblInfoToken)
        Me.pnlMain.Controls.Add(Me.gbInfo)
        Me.pnlMain.Controls.Add(Me.PictureBox1)
        Me.pnlMain.Enabled = False
        Me.pnlMain.Location = New System.Drawing.Point(1, 27)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(707, 497)
        Me.pnlMain.TabIndex = 10
        '
        'lblSendChatInfoID
        '
        Me.lblSendChatInfoID.AutoSize = True
        Me.lblSendChatInfoID.Location = New System.Drawing.Point(406, 54)
        Me.lblSendChatInfoID.Name = "lblSendChatInfoID"
        Me.lblSendChatInfoID.Size = New System.Drawing.Size(47, 15)
        Me.lblSendChatInfoID.TabIndex = 23
        Me.lblSendChatInfoID.Text = "Chat ID"
        '
        'txtChatID
        '
        Me.txtChatID.Location = New System.Drawing.Point(465, 51)
        Me.txtChatID.Name = "txtChatID"
        Me.txtChatID.Size = New System.Drawing.Size(230, 23)
        Me.txtChatID.TabIndex = 24
        '
        'gbSendItem
        '
        Me.gbSendItem.Controls.Add(Me.btnSend)
        Me.gbSendItem.Controls.Add(Me.lblSendItemID)
        Me.gbSendItem.Controls.Add(Me.txtSendItemID)
        Me.gbSendItem.Controls.Add(Me.rbVoice)
        Me.gbSendItem.Controls.Add(Me.rbVideo)
        Me.gbSendItem.Controls.Add(Me.rbSticker)
        Me.gbSendItem.Controls.Add(Me.rbDocument)
        Me.gbSendItem.Controls.Add(Me.rbAudio)
        Me.gbSendItem.Controls.Add(Me.rbPhoto)
        Me.gbSendItem.Enabled = False
        Me.gbSendItem.Location = New System.Drawing.Point(400, 364)
        Me.gbSendItem.Name = "gbSendItem"
        Me.gbSendItem.Size = New System.Drawing.Size(295, 122)
        Me.gbSendItem.TabIndex = 22
        Me.gbSendItem.TabStop = False
        Me.gbSendItem.Text = "Send Item"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(192, 78)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(94, 44)
        Me.btnSend.TabIndex = 22
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lblSendItemID
        '
        Me.lblSendItemID.AutoSize = True
        Me.lblSendItemID.Location = New System.Drawing.Point(6, 96)
        Me.lblSendItemID.Name = "lblSendItemID"
        Me.lblSendItemID.Size = New System.Drawing.Size(19, 15)
        Me.lblSendItemID.TabIndex = 13
        Me.lblSendItemID.Text = "ID"
        '
        'txtSendItemID
        '
        Me.txtSendItemID.Location = New System.Drawing.Point(31, 93)
        Me.txtSendItemID.Name = "txtSendItemID"
        Me.txtSendItemID.Size = New System.Drawing.Size(155, 23)
        Me.txtSendItemID.TabIndex = 14
        '
        'rbVoice
        '
        Me.rbVoice.AutoSize = True
        Me.rbVoice.Location = New System.Drawing.Point(90, 22)
        Me.rbVoice.Name = "rbVoice"
        Me.rbVoice.Size = New System.Drawing.Size(54, 19)
        Me.rbVoice.TabIndex = 5
        Me.rbVoice.TabStop = True
        Me.rbVoice.Text = "Voice"
        Me.rbVoice.UseVisualStyleBackColor = True
        '
        'rbVideo
        '
        Me.rbVideo.AutoSize = True
        Me.rbVideo.Location = New System.Drawing.Point(10, 47)
        Me.rbVideo.Name = "rbVideo"
        Me.rbVideo.Size = New System.Drawing.Size(56, 19)
        Me.rbVideo.TabIndex = 4
        Me.rbVideo.TabStop = True
        Me.rbVideo.Text = "Video"
        Me.rbVideo.UseVisualStyleBackColor = True
        '
        'rbSticker
        '
        Me.rbSticker.AutoSize = True
        Me.rbSticker.Location = New System.Drawing.Point(182, 22)
        Me.rbSticker.Name = "rbSticker"
        Me.rbSticker.Size = New System.Drawing.Size(55, 19)
        Me.rbSticker.TabIndex = 3
        Me.rbSticker.TabStop = True
        Me.rbSticker.Text = "Stiker"
        Me.rbSticker.UseVisualStyleBackColor = True
        '
        'rbDocument
        '
        Me.rbDocument.AutoSize = True
        Me.rbDocument.Location = New System.Drawing.Point(90, 47)
        Me.rbDocument.Name = "rbDocument"
        Me.rbDocument.Size = New System.Drawing.Size(80, 19)
        Me.rbDocument.TabIndex = 2
        Me.rbDocument.TabStop = True
        Me.rbDocument.Text = "Document"
        Me.rbDocument.UseVisualStyleBackColor = True
        '
        'rbAudio
        '
        Me.rbAudio.AutoSize = True
        Me.rbAudio.Location = New System.Drawing.Point(182, 47)
        Me.rbAudio.Name = "rbAudio"
        Me.rbAudio.Size = New System.Drawing.Size(57, 19)
        Me.rbAudio.TabIndex = 1
        Me.rbAudio.TabStop = True
        Me.rbAudio.Text = "Audio"
        Me.rbAudio.UseVisualStyleBackColor = True
        '
        'rbPhoto
        '
        Me.rbPhoto.AutoSize = True
        Me.rbPhoto.Location = New System.Drawing.Point(9, 22)
        Me.rbPhoto.Name = "rbPhoto"
        Me.rbPhoto.Size = New System.Drawing.Size(57, 19)
        Me.rbPhoto.TabIndex = 0
        Me.rbPhoto.TabStop = True
        Me.rbPhoto.Text = "Photo"
        Me.rbPhoto.UseVisualStyleBackColor = True
        '
        'gbForward
        '
        Me.gbForward.Controls.Add(Me.btnForward)
        Me.gbForward.Controls.Add(Me.lblForwardMessageID)
        Me.gbForward.Controls.Add(Me.txtForwardMessageID)
        Me.gbForward.Controls.Add(Me.lblFromChatID)
        Me.gbForward.Controls.Add(Me.txtForwardFromChatID)
        Me.gbForward.Enabled = False
        Me.gbForward.Location = New System.Drawing.Point(400, 268)
        Me.gbForward.Name = "gbForward"
        Me.gbForward.Size = New System.Drawing.Size(295, 90)
        Me.gbForward.TabIndex = 21
        Me.gbForward.TabStop = False
        Me.gbForward.Text = "Forward Message"
        '
        'btnForward
        '
        Me.btnForward.Location = New System.Drawing.Point(195, 27)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(94, 44)
        Me.btnForward.TabIndex = 21
        Me.btnForward.Text = "Forward Message"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'lblForwardMessageID
        '
        Me.lblForwardMessageID.AutoSize = True
        Me.lblForwardMessageID.Location = New System.Drawing.Point(6, 56)
        Me.lblForwardMessageID.Name = "lblForwardMessageID"
        Me.lblForwardMessageID.Size = New System.Drawing.Size(70, 15)
        Me.lblForwardMessageID.TabIndex = 15
        Me.lblForwardMessageID.Text = "Message ID"
        '
        'txtForwardMessageID
        '
        Me.txtForwardMessageID.Location = New System.Drawing.Point(90, 53)
        Me.txtForwardMessageID.Name = "txtForwardMessageID"
        Me.txtForwardMessageID.Size = New System.Drawing.Size(99, 23)
        Me.txtForwardMessageID.TabIndex = 16
        '
        'lblFromChatID
        '
        Me.lblFromChatID.AutoSize = True
        Me.lblFromChatID.Location = New System.Drawing.Point(6, 27)
        Me.lblFromChatID.Name = "lblFromChatID"
        Me.lblFromChatID.Size = New System.Drawing.Size(78, 15)
        Me.lblFromChatID.TabIndex = 11
        Me.lblFromChatID.Text = "From Chat ID"
        '
        'txtForwardFromChatID
        '
        Me.txtForwardFromChatID.Location = New System.Drawing.Point(90, 24)
        Me.txtForwardFromChatID.Name = "txtForwardFromChatID"
        Me.txtForwardFromChatID.Size = New System.Drawing.Size(99, 23)
        Me.txtForwardFromChatID.TabIndex = 12
        '
        'gbSend
        '
        Me.gbSend.Controls.Add(Me.Label1)
        Me.gbSend.Controls.Add(Me.txtIDMessageReply)
        Me.gbSend.Controls.Add(Me.chkReplyToMessage)
        Me.gbSend.Controls.Add(Me.cboSendAction)
        Me.gbSend.Controls.Add(Me.btnSendChatAction)
        Me.gbSend.Controls.Add(Me.btnSendMessage)
        Me.gbSend.Controls.Add(Me.lbLSendInfoText)
        Me.gbSend.Controls.Add(Me.txtSendText)
        Me.gbSend.Enabled = False
        Me.gbSend.Location = New System.Drawing.Point(400, 80)
        Me.gbSend.Name = "gbSend"
        Me.gbSend.Size = New System.Drawing.Size(295, 182)
        Me.gbSend.TabIndex = 17
        Me.gbSend.TabStop = False
        Me.gbSend.Text = "Send Message"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID"
        '
        'txtIDMessageReply
        '
        Me.txtIDMessageReply.Enabled = False
        Me.txtIDMessageReply.Location = New System.Drawing.Point(53, 154)
        Me.txtIDMessageReply.Name = "txtIDMessageReply"
        Me.txtIDMessageReply.Size = New System.Drawing.Size(136, 23)
        Me.txtIDMessageReply.TabIndex = 18
        '
        'chkReplyToMessage
        '
        Me.chkReplyToMessage.AutoSize = True
        Me.chkReplyToMessage.Location = New System.Drawing.Point(53, 130)
        Me.chkReplyToMessage.Name = "chkReplyToMessage"
        Me.chkReplyToMessage.Size = New System.Drawing.Size(136, 19)
        Me.chkReplyToMessage.TabIndex = 17
        Me.chkReplyToMessage.Text = "Reply to a message?"
        Me.chkReplyToMessage.UseVisualStyleBackColor = True
        '
        'cboSendAction
        '
        Me.cboSendAction.FormattingEnabled = True
        Me.cboSendAction.Items.AddRange(New Object() {"typing", "upload_photo", "record_video", "upload_video", "record_audio", "upload_audio", "upload_document", "find_location"})
        Me.cboSendAction.Location = New System.Drawing.Point(59, 27)
        Me.cboSendAction.Name = "cboSendAction"
        Me.cboSendAction.Size = New System.Drawing.Size(130, 23)
        Me.cboSendAction.TabIndex = 16
        Me.cboSendAction.Text = "typing"
        '
        'btnSendChatAction
        '
        Me.btnSendChatAction.Location = New System.Drawing.Point(195, 16)
        Me.btnSendChatAction.Name = "btnSendChatAction"
        Me.btnSendChatAction.Size = New System.Drawing.Size(94, 44)
        Me.btnSendChatAction.TabIndex = 15
        Me.btnSendChatAction.Text = "Send chat action"
        Me.btnSendChatAction.UseVisualStyleBackColor = True
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Location = New System.Drawing.Point(195, 133)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(94, 44)
        Me.btnSendMessage.TabIndex = 13
        Me.btnSendMessage.Text = "Send Message"
        Me.btnSendMessage.UseVisualStyleBackColor = True
        '
        'lbLSendInfoText
        '
        Me.lbLSendInfoText.AutoSize = True
        Me.lbLSendInfoText.Location = New System.Drawing.Point(6, 50)
        Me.lbLSendInfoText.Name = "lbLSendInfoText"
        Me.lbLSendInfoText.Size = New System.Drawing.Size(28, 15)
        Me.lbLSendInfoText.TabIndex = 12
        Me.lbLSendInfoText.Text = "Text"
        '
        'txtSendText
        '
        Me.txtSendText.Location = New System.Drawing.Point(6, 68)
        Me.txtSendText.Multiline = True
        Me.txtSendText.Name = "txtSendText"
        Me.txtSendText.Size = New System.Drawing.Size(280, 61)
        Me.txtSendText.TabIndex = 11
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblFilePath.Location = New System.Drawing.Point(206, 23)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(11, 15)
        Me.lblFilePath.TabIndex = 15
        Me.lblFilePath.Text = "-"
        '
        'lblInfoFilePath
        '
        Me.lblInfoFilePath.AutoSize = True
        Me.lblInfoFilePath.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoFilePath.Location = New System.Drawing.Point(140, 23)
        Me.lblInfoFilePath.Name = "lblInfoFilePath"
        Me.lblInfoFilePath.Size = New System.Drawing.Size(60, 15)
        Me.lblInfoFilePath.TabIndex = 16
        Me.lblInfoFilePath.Text = "FILE PATH:"
        '
        'gbPreview
        '
        Me.gbPreview.Controls.Add(Me.lblIDMsg)
        Me.gbPreview.Controls.Add(Me.lblInfoIDMsg)
        Me.gbPreview.Controls.Add(Me.lblInfoText)
        Me.gbPreview.Controls.Add(Me.lblDate)
        Me.gbPreview.Controls.Add(Me.lblInfoDate)
        Me.gbPreview.Controls.Add(Me.lblChatID)
        Me.gbPreview.Controls.Add(Me.lblInfoChat)
        Me.gbPreview.Controls.Add(Me.lblFrom)
        Me.gbPreview.Controls.Add(Me.lblInfoFrom)
        Me.gbPreview.Controls.Add(Me.lblMessageType)
        Me.gbPreview.Controls.Add(Me.lblInfoMessageType)
        Me.gbPreview.Controls.Add(Me.txtText)
        Me.gbPreview.Location = New System.Drawing.Point(111, 180)
        Me.gbPreview.Name = "gbPreview"
        Me.gbPreview.Size = New System.Drawing.Size(283, 306)
        Me.gbPreview.TabIndex = 9
        Me.gbPreview.TabStop = False
        Me.gbPreview.Text = "Update preview"
        '
        'lblIDMsg
        '
        Me.lblIDMsg.AutoSize = True
        Me.lblIDMsg.Location = New System.Drawing.Point(95, 50)
        Me.lblIDMsg.Name = "lblIDMsg"
        Me.lblIDMsg.Size = New System.Drawing.Size(0, 15)
        Me.lblIDMsg.TabIndex = 11
        '
        'lblInfoIDMsg
        '
        Me.lblInfoIDMsg.AutoSize = True
        Me.lblInfoIDMsg.Location = New System.Drawing.Point(6, 50)
        Me.lblInfoIDMsg.Name = "lblInfoIDMsg"
        Me.lblInfoIDMsg.Size = New System.Drawing.Size(19, 15)
        Me.lblInfoIDMsg.TabIndex = 10
        Me.lblInfoIDMsg.Text = "ID"
        '
        'lblInfoText
        '
        Me.lblInfoText.AutoSize = True
        Me.lblInfoText.Location = New System.Drawing.Point(6, 142)
        Me.lblInfoText.Name = "lblInfoText"
        Me.lblInfoText.Size = New System.Drawing.Size(28, 15)
        Me.lblInfoText.TabIndex = 9
        Me.lblInfoText.Text = "Text"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(95, 110)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 15)
        Me.lblDate.TabIndex = 8
        '
        'lblInfoDate
        '
        Me.lblInfoDate.AutoSize = True
        Me.lblInfoDate.Location = New System.Drawing.Point(6, 110)
        Me.lblInfoDate.Name = "lblInfoDate"
        Me.lblInfoDate.Size = New System.Drawing.Size(35, 15)
        Me.lblInfoDate.TabIndex = 7
        Me.lblInfoDate.Text = "Date:"
        '
        'lblChatID
        '
        Me.lblChatID.AutoSize = True
        Me.lblChatID.LinkColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblChatID.Location = New System.Drawing.Point(95, 90)
        Me.lblChatID.Name = "lblChatID"
        Me.lblChatID.Size = New System.Drawing.Size(0, 15)
        Me.lblChatID.TabIndex = 6
        '
        'lblInfoChat
        '
        Me.lblInfoChat.AutoSize = True
        Me.lblInfoChat.Location = New System.Drawing.Point(6, 90)
        Me.lblInfoChat.Name = "lblInfoChat"
        Me.lblInfoChat.Size = New System.Drawing.Size(35, 15)
        Me.lblInfoChat.TabIndex = 5
        Me.lblInfoChat.Text = "Chat:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.LinkColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(95, 70)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(0, 15)
        Me.lblFrom.TabIndex = 4
        '
        'lblInfoFrom
        '
        Me.lblInfoFrom.AutoSize = True
        Me.lblInfoFrom.Location = New System.Drawing.Point(6, 70)
        Me.lblInfoFrom.Name = "lblInfoFrom"
        Me.lblInfoFrom.Size = New System.Drawing.Size(38, 15)
        Me.lblInfoFrom.TabIndex = 3
        Me.lblInfoFrom.Text = "From:"
        '
        'lblMessageType
        '
        Me.lblMessageType.AutoSize = True
        Me.lblMessageType.LinkColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMessageType.Location = New System.Drawing.Point(95, 30)
        Me.lblMessageType.Name = "lblMessageType"
        Me.lblMessageType.Size = New System.Drawing.Size(0, 15)
        Me.lblMessageType.TabIndex = 2
        '
        'lblInfoMessageType
        '
        Me.lblInfoMessageType.AutoSize = True
        Me.lblInfoMessageType.Location = New System.Drawing.Point(6, 30)
        Me.lblInfoMessageType.Name = "lblInfoMessageType"
        Me.lblInfoMessageType.Size = New System.Drawing.Size(85, 15)
        Me.lblInfoMessageType.TabIndex = 1
        Me.lblInfoMessageType.Text = "Message Type:"
        '
        'txtText
        '
        Me.txtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.Location = New System.Drawing.Point(9, 160)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ReadOnly = True
        Me.txtText.Size = New System.Drawing.Size(263, 140)
        Me.txtText.TabIndex = 0
        '
        'lstUpdates
        '
        Me.lstUpdates.BackColor = System.Drawing.SystemColors.Control
        Me.lstUpdates.FormattingEnabled = True
        Me.lstUpdates.ItemHeight = 15
        Me.lstUpdates.Location = New System.Drawing.Point(11, 180)
        Me.lstUpdates.Name = "lstUpdates"
        Me.lstUpdates.Size = New System.Drawing.Size(94, 259)
        Me.lstUpdates.TabIndex = 14
        '
        'btnGetUpdates
        '
        Me.btnGetUpdates.Location = New System.Drawing.Point(11, 442)
        Me.btnGetUpdates.Name = "btnGetUpdates"
        Me.btnGetUpdates.Size = New System.Drawing.Size(94, 44)
        Me.btnGetUpdates.TabIndex = 9
        Me.btnGetUpdates.Text = "Get Updates"
        Me.btnGetUpdates.UseVisualStyleBackColor = True
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToken.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblToken.Location = New System.Drawing.Point(206, 3)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(11, 15)
        Me.lblToken.TabIndex = 12
        Me.lblToken.Text = "-"
        '
        'lblInfoToken
        '
        Me.lblInfoToken.AutoSize = True
        Me.lblInfoToken.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoToken.Location = New System.Drawing.Point(151, 3)
        Me.lblInfoToken.Name = "lblInfoToken"
        Me.lblInfoToken.Size = New System.Drawing.Size(49, 15)
        Me.lblInfoToken.TabIndex = 13
        Me.lblInfoToken.Text = "TOKEN :"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.lblUsername)
        Me.gbInfo.Controls.Add(Me.lblLName)
        Me.gbInfo.Controls.Add(Me.lblFName)
        Me.gbInfo.Controls.Add(Me.lblID)
        Me.gbInfo.Controls.Add(Me.lblInfoUsername)
        Me.gbInfo.Controls.Add(Me.lblInfoLName)
        Me.gbInfo.Controls.Add(Me.lblInfoFName)
        Me.gbInfo.Controls.Add(Me.lblInfoID)
        Me.gbInfo.Location = New System.Drawing.Point(145, 46)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(249, 128)
        Me.gbInfo.TabIndex = 11
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Bot info"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(118, 100)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(11, 15)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "-"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(118, 73)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(11, 15)
        Me.lblLName.TabIndex = 6
        Me.lblLName.Text = "-"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(118, 46)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(11, 15)
        Me.lblFName.TabIndex = 5
        Me.lblFName.Text = "-"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(118, 22)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(11, 15)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "-"
        '
        'lblInfoUsername
        '
        Me.lblInfoUsername.AutoSize = True
        Me.lblInfoUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoUsername.Location = New System.Drawing.Point(6, 100)
        Me.lblInfoUsername.Name = "lblInfoUsername"
        Me.lblInfoUsername.Size = New System.Drawing.Size(68, 15)
        Me.lblInfoUsername.TabIndex = 3
        Me.lblInfoUsername.Text = "Username: "
        '
        'lblInfoLName
        '
        Me.lblInfoLName.AutoSize = True
        Me.lblInfoLName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoLName.Location = New System.Drawing.Point(6, 73)
        Me.lblInfoLName.Name = "lblInfoLName"
        Me.lblInfoLName.Size = New System.Drawing.Size(69, 15)
        Me.lblInfoLName.TabIndex = 2
        Me.lblInfoLName.Text = "Last Name: "
        '
        'lblInfoFName
        '
        Me.lblInfoFName.AutoSize = True
        Me.lblInfoFName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoFName.Location = New System.Drawing.Point(6, 46)
        Me.lblInfoFName.Name = "lblInfoFName"
        Me.lblInfoFName.Size = New System.Drawing.Size(69, 15)
        Me.lblInfoFName.TabIndex = 1
        Me.lblInfoFName.Text = "First Name:"
        '
        'lblInfoID
        '
        Me.lblInfoID.AutoSize = True
        Me.lblInfoID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoID.Location = New System.Drawing.Point(6, 21)
        Me.lblInfoID.Name = "lblInfoID"
        Me.lblInfoID.Size = New System.Drawing.Size(22, 15)
        Me.lblInfoID.TabIndex = 0
        Me.lblInfoID.Text = "ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TelegramApiTester.My.Resources.Resources.Telegram_128
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(8, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 525)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.MainMenu)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telegram API Tester - BOT"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.gbSendItem.ResumeLayout(False)
        Me.gbSendItem.PerformLayout()
        Me.gbForward.ResumeLayout(False)
        Me.gbForward.PerformLayout()
        Me.gbSend.ResumeLayout(False)
        Me.gbSend.PerformLayout()
        Me.gbPreview.ResumeLayout(False)
        Me.gbPreview.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblToken As System.Windows.Forms.Label
    Friend WithEvents lblInfoToken As System.Windows.Forms.Label
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblInfoUsername As System.Windows.Forms.Label
    Friend WithEvents lblInfoLName As System.Windows.Forms.Label
    Friend WithEvents lblInfoFName As System.Windows.Forms.Label
    Friend WithEvents lblInfoID As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGetUpdates As System.Windows.Forms.Button
    Friend WithEvents lstUpdates As System.Windows.Forms.ListBox
    Friend WithEvents gbPreview As System.Windows.Forms.GroupBox
    Friend WithEvents lblMessageType As System.Windows.Forms.LinkLabel
    Friend WithEvents lblInfoMessageType As System.Windows.Forms.Label
    Friend WithEvents lblInfoText As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblInfoDate As System.Windows.Forms.Label
    Friend WithEvents lblChatID As System.Windows.Forms.LinkLabel
    Friend WithEvents lblInfoChat As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.LinkLabel
    Friend WithEvents lblInfoFrom As System.Windows.Forms.Label
    Friend WithEvents tsmiToken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiFilePath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents lblInfoFilePath As System.Windows.Forms.Label
    Friend WithEvents gbSend As System.Windows.Forms.GroupBox
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnSendChatAction As System.Windows.Forms.Button
    Friend WithEvents cboSendAction As System.Windows.Forms.ComboBox
    Friend WithEvents btnSendMessage As System.Windows.Forms.Button
    Friend WithEvents lbLSendInfoText As System.Windows.Forms.Label
    Friend WithEvents txtSendText As System.Windows.Forms.TextBox
    Friend WithEvents lblIDMsg As System.Windows.Forms.Label
    Friend WithEvents lblInfoIDMsg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDMessageReply As System.Windows.Forms.TextBox
    Friend WithEvents chkReplyToMessage As System.Windows.Forms.CheckBox
    Friend WithEvents gbForward As System.Windows.Forms.GroupBox
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents lblForwardMessageID As System.Windows.Forms.Label
    Friend WithEvents txtForwardMessageID As System.Windows.Forms.TextBox
    Friend WithEvents lblFromChatID As System.Windows.Forms.Label
    Friend WithEvents txtForwardFromChatID As System.Windows.Forms.TextBox
    Friend WithEvents gbSendItem As System.Windows.Forms.GroupBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents lblSendItemID As System.Windows.Forms.Label
    Friend WithEvents txtSendItemID As System.Windows.Forms.TextBox
    Friend WithEvents rbVoice As System.Windows.Forms.RadioButton
    Friend WithEvents rbVideo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSticker As System.Windows.Forms.RadioButton
    Friend WithEvents rbDocument As System.Windows.Forms.RadioButton
    Friend WithEvents rbAudio As System.Windows.Forms.RadioButton
    Friend WithEvents rbPhoto As System.Windows.Forms.RadioButton
    Friend WithEvents lblSendChatInfoID As System.Windows.Forms.Label
    Friend WithEvents txtChatID As System.Windows.Forms.TextBox

End Class
