Imports System.Reflection

Public Class TelegramObject

    Public Property ok As Object
    Public Property result As Object 'Here we have the object that we need (user, chat etc..)
    Public Property error_code As Integer
    Public Property description As String

    Public Sub New(ByVal sJSON As String)
        'Deserializing the JSON object and populate the TelegramObject
        Dim js As New Web.Script.Serialization.JavaScriptSerializer
        Dim d As Dictionary(Of String, Object) = CType(js.DeserializeObject(sJSON), Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class User

    Public Property id As Integer 'Unique identifier for this user or bot
    Public Property first_name As String 'User's or bot's  first name
    Public Property last_name As String   'User‘s or bot’s last name
    Public Property username As String 'User‘s or bot’s username

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class Update

    Public Property update_id As Integer 'The update‘s unique identifier
    Public Property message As Message 'Optional. New incoming message of any kind — text, photo, sticker, etc.

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    If p.Name = "message" Then
                        Dim Message As New Message
                        Message.Map(kvp.Value)
                        p.SetValue(Me, Message)
                    Else
                        p.SetValue(Me, kvp.Value)
                    End If
                    Exit For
                End If
            Next
        Next

    End Sub

End Class

Public Class Message

    Public Property message_id As Integer 'Unique message identifier
    Public Property from As User 'Optional. Sender, can be empty for messages sent to channels
    Public Property _date As Integer 'Date the message was sent in Unix time
    Public Property chat As Chat    'Conversation the message belongs to
    Public Property forward_from As User    'Optional. For forwarded messages, sender of the original message
    Public Property forward_date As Integer 'Optional. For forwarded messages, date the original message was sent in Unix time
    Public Property reply_to_message As Message 'Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
    Public Property text As String  'Optional. For text messages, the actual UTF-8 text of the message
    Public Property audio As Audio   'Optional. Message is an audio file, information about the file
    Public Property document As Document    'Optional. Message is a general file, information about the file
    Public Property photo As List(Of PhotoSize)  'Optional. Message is a photo, available sizes of the photo
    Public Property sticker As Sticker 'Optional. Message is a sticker, information about the sticker
    Public Property video As Video   'Optional. Message is a video, information about the video
    Public Property voice As Voice   'Optional. Message is a voice message, information about the file
    Public Property caption As String  'Optional. Caption for the photo or video
    Public Property contact As Contact 'Optional. Message is a shared contact, information about the contact
    Public Property location As Location    'Optional. Message is a shared location, information about the location
    Public Property new_chat_participant As User    'Optional. A new member was added to the group, information about them (this member may be the bot itself)
    Public Property left_chat_participant As User    'Optional. A member was removed from the group, information about them (this member may be the bot itself)
    Public Property new_chat_title As String  'Optional. A chat title was changed to this value
    Public Property new_chat_photo As List(Of PhotoSize)  'Optional. A chat photo was change to this value
    Public Property delete_chat_photo As Boolean 'Optional. Service message: the chat photo was deleted
    Public Property group_chat_created As Boolean 'Optional. Service message: the group has been created
    Public Property supergroup_chat_created As Boolean 'Optional. Service message: the supergroup has been created
    Public Property channel_chat_created As Boolean 'Optional. Service message: the channel has been created
    Public Property migrate_to_chat_id As Integer '	Optional. The group has been migrated to a supergroup with the specified identifier, not exceeding 1e13 by absolute value
    Public Property migrate_from_chat_id As Integer 'Optional. The supergroup has been migrated from a group with the specified identifier, not exceeding 1e13 by absolute value

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    Select Case p.Name
                        Case "from"
                            Dim User As New User
                            User.Map(kvp.Value)
                            p.SetValue(Me, User)
                        Case "chat"
                            Dim Chat As New Chat
                            Chat.Map(kvp.Value)
                            p.SetValue(Me, Chat)
                        Case "forward_from"
                            Dim User As New User
                            User.Map(kvp.Value)
                            p.SetValue(Me, User)
                        Case "reply_to_message"
                            Dim Msg As New Message
                            Msg.Map(kvp.Value)
                            p.SetValue(Me, Msg)
                        Case "audio"
                            Dim Audio As New Audio
                            Audio.Map(kvp.Value)
                            p.SetValue(Me, Audio)
                        Case "document"
                            Dim Document As New Document
                            Document.Map(kvp.Value)
                            p.SetValue(Me, Document)
                        Case "photo"
                            Dim photos As New List(Of PhotoSize)
                            For i As Integer = 0 To CType(kvp.Value, Object()).Count - 1
                                Dim photoDict As Dictionary(Of String, Object) = CType(kvp.Value(i), Dictionary(Of String, Object))
                                Dim Photo As New PhotoSize
                                Photo.Map(photoDict)
                                photos.Add(Photo)
                            Next
                            p.SetValue(Me, photos)
                        Case "sticker"
                            Dim Sticker As New Sticker
                            Sticker.Map(kvp.Value)
                            p.SetValue(Me, Sticker)
                        Case "video"
                            Dim Video As New Video
                            Video.Map(kvp.Value)
                            p.SetValue(Me, Video)
                        Case "voice"
                            Dim Voice As New Voice
                            Voice.Map(kvp.Value)
                            p.SetValue(Me, Voice)
                        Case "contact"
                            Dim Contact As New Contact
                            Contact.Map(kvp.Value)
                            p.SetValue(Me, Contact)
                        Case "location"
                            Dim Location As New Location
                            Location.Map(kvp.Value)
                            p.SetValue(Me, Location)
                        Case "new_chat_participant"
                            Dim User As New User
                            User.Map(kvp.Value)
                            p.SetValue(Me, User)
                        Case "left_chat_participant"
                            Dim User As New User
                            User.Map(kvp.Value)
                            p.SetValue(Me, User)
                        Case "new_chat_photo"
                            Dim photos As New List(Of PhotoSize)
                            For i As Integer = 0 To DirectCast(kvp.Value, Object()).Count - 1
                                Dim photoDict As Dictionary(Of String, Object) = CType(kvp.Value(i), Dictionary(Of String, Object))
                                Dim Photo As New PhotoSize
                                Photo.Map(photoDict)
                                photos.Add(Photo)
                            Next
                            p.SetValue(Me, photos)
                        Case Else
                            p.SetValue(Me, kvp.Value)
                            Exit For
                    End Select
                End If
                'Extra, since it's impossible to assign "date" as variable name, I need to map it manually
                If kvp.Key = "date" Then
                    Me._date = kvp.Value
                End If
            Next
        Next
    End Sub

    Public Enum MessageType
        Text = 0
        Audio = 1
        Document = 2
        Photo = 3
        Sticker = 4
        Video = 5
        Voice = 6
        Contact = 7
        Location = 8
        NewMember = 9
        MemberLeft = 10
        NewChatTitle = 11
        NewChatPhoto = 12
        SistemMessage = 13
        Undefinied = 14
    End Enum

    Public Function GetMessageType() As MessageType
        If Not String.IsNullOrEmpty(Me.text) Then Return MessageType.Text
        If Not Me.audio Is Nothing Then Return MessageType.Audio
        If Not Me.document Is Nothing Then Return MessageType.Document
        If Not Me.photo Is Nothing Then Return MessageType.Photo
        If Not Me.sticker Is Nothing Then Return MessageType.Sticker
        If Not Me.video Is Nothing Then Return MessageType.Video
        If Not Me.voice Is Nothing Then Return MessageType.Voice
        If Not Me.contact Is Nothing Then Return MessageType.Contact
        If Not Me.location Is Nothing Then Return MessageType.Location
        If Not Me.new_chat_participant Is Nothing Then Return MessageType.NewMember
        If Not Me.left_chat_participant Is Nothing Then Return MessageType.MemberLeft
        If Not Me.new_chat_title Is Nothing Then Return MessageType.NewChatTitle
        If Not Me.new_chat_photo Is Nothing Then Return MessageType.NewChatPhoto
        If Me.delete_chat_photo OrElse _
           Me.group_chat_created OrElse _
           Me.supergroup_chat_created OrElse _
           Me.channel_chat_created Then Return MessageType.SistemMessage
        Return MessageType.Undefinied
    End Function


End Class

Public Class PhotoSize

    Public Property file_id As String  'Unique identifier for this file
    Public Property width As Integer 'Photo width
    Public Property height As Integer 'Photo height
    Public Property file_size As Integer 'Optional. File size

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class Audio

    Public Property file_id As String  'Unique identifier for this file
    Public Property duration As Integer 'Duration of the audio in seconds as defined by sender
    Public Property performer As String  'Optional. Performer of the audio as defined by sender or by audio tags
    Public Property title As String  'Optional. Title of the audio as defined by sender or by audio tags
    Public Property mime_type As String  'Optional. MIME type of the file as defined by sender
    Public Property file_size As Integer 'Optional. File size

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class Chat

    Public Property id As Integer 'Unique identifier for this chat, not exceeding 1e13 by absolute value
    Public Property type As String  'Type of chat, can be either “private”, “group”, “supergroup” or “channel”
    Public Property title As String  'Optional. Title, for channels and group chats
    Public Property username As String  'Optional. Username, for private chats and channels if available
    Public Property first_name As String  'Optional. First name of the other party in a private chat
    Public Property last_name As String  'Optional. Last name of the other party in a private chat

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class Document

    Public Property file_id As String  'Unique file identifier
    Public Property thumb As PhotoSize   'Optional. Document thumbnail as defined by sender
    Public Property file_name As String  'Optional. Original filename as defined by sender
    Public Property mime_type As String  'Optional. MIME type of the file as defined by sender
    Public Property file_size As Integer 'Optional. File size

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    If p.Name = "from" Then
                        Dim PS As New PhotoSize
                        PS.Map(kvp.Value)
                        p.SetValue(Me, PS)
                    Else
                        p.SetValue(Me, kvp.Value)
                        Exit For
                    End If
                End If
            Next
        Next
    End Sub

End Class

Public Class Sticker

    Public Property file_id As String 'Unique identifier for this file
    Public Property width As Integer 'Sticker width
    Public Property height As Integer 'Sticker height
    Public Property thumb As PhotoSize   'Optional. Sticker thumbnail in .webp or .jpg format
    Public Property file_size As Integer 'Optional. File size

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    If p.Name = "thumb" Then
                        Dim PS As New PhotoSize
                        PS.Map(kvp.Value)
                        p.SetValue(Me, PS)
                    Else
                        p.SetValue(Me, kvp.Value)
                        Exit For
                    End If
                End If
            Next
        Next
    End Sub
End Class

Public Class Video

    Public Property file_id As String  'Unique identifier for this file
    Public Property width As Integer 'Video width as defined by sender
    Public Property height As Integer 'Video height as defined by sender
    Public Property duration As Integer 'Duration of the video in seconds as defined by sender
    Public Property thumb As PhotoSize   'Optional. Video thumbnail
    Public Property mime_type As String  'Optional. Mime type of a file as defined by sender
    Public Property file_size As Integer 'Optional. File size

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    If p.Name = "thumb" Then
                        Dim PS As New PhotoSize
                        PS.Map(kvp.Value)
                        p.SetValue(Me, PS)
                    Else
                        p.SetValue(Me, kvp.Value)
                        Exit For
                    End If
                End If
            Next
        Next
    End Sub

End Class

Public Class Voice

    Public Property file_id As String  'Unique identifier for this file
    Public Property duration As Integer 'Duration of the audio in seconds as defined by sender
    Public Property mime_type As String  'Optional. MIME type of the file as defined by sender
    Public Property file_size As Integer 'Optional. File size

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class Contact

    Public Property phone_number As String  'Contact's phone number
    Public Property first_name As String   'Contact's first name
    Public Property last_name As String  'Optional. Contact's last name
    Public Property user_id As Integer 'Optional. Contact's user identifier in Telegram

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class Location

    Public Property longitude As Double   'Longitude as defined by sender
    Public Property latitude As Double   'Latitude as defined by sender

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class

Public Class File

    Public Property file_id As String    'Unique identifier for this file
    Public Property file_size As Integer 'Optional. File size, if known
    Public Property file_path As String  'Optional. File path. Use https://api.telegram.org/file/bot<token>/<file_path> to get the file.

    Public Sub Map(ByVal obj As Object)
        Dim d As Dictionary(Of String, Object) = CType(obj, Dictionary(Of String, Object))
        Dim properties() As PropertyInfo = Me.GetType.GetProperties
        For Each p As PropertyInfo In properties
            For Each kvp As KeyValuePair(Of String, Object) In d
                If p.Name = kvp.Key Then
                    p.SetValue(Me, kvp.Value)
                    Exit For
                End If
            Next
        Next
    End Sub

End Class