<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bookCondition = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bookGenre = New System.Windows.Forms.TextBox()
        Me.bookAuthor = New System.Windows.Forms.TextBox()
        Me.bookTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titleTxtbox = New System.Windows.Forms.TextBox()
        Me.authorTxtbox = New System.Windows.Forms.TextBox()
        Me.genreTxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bookStatus = New System.Windows.Forms.ComboBox()
        Me.addButon = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.bookCondition)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.bookGenre)
        Me.Panel1.Controls.Add(Me.bookAuthor)
        Me.Panel1.Controls.Add(Me.bookTitle)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(229, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 577)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(20, 504)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Total Books released:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BOOK MANAGEMENT"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(529, 253)
        Me.DataGridView1.TabIndex = 0
        '
        'bookCondition
        '
        Me.bookCondition.AutoSize = True
        Me.bookCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookCondition.Location = New System.Drawing.Point(260, 440)
        Me.bookCondition.Name = "bookCondition"
        Me.bookCondition.Size = New System.Drawing.Size(142, 20)
        Me.bookCondition.TabIndex = 1
        Me.bookCondition.Text = "Book Condition:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Book Genre:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(254, 463)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(176, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(260, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Book Author:"
        '
        'bookGenre
        '
        Me.bookGenre.Location = New System.Drawing.Point(15, 463)
        Me.bookGenre.Name = "bookGenre"
        Me.bookGenre.Size = New System.Drawing.Size(176, 22)
        Me.bookGenre.TabIndex = 2
        '
        'bookAuthor
        '
        Me.bookAuthor.Location = New System.Drawing.Point(254, 402)
        Me.bookAuthor.Name = "bookAuthor"
        Me.bookAuthor.Size = New System.Drawing.Size(176, 22)
        Me.bookAuthor.TabIndex = 2
        '
        'bookTitle
        '
        Me.bookTitle.Location = New System.Drawing.Point(15, 402)
        Me.bookTitle.Name = "bookTitle"
        Me.bookTitle.Size = New System.Drawing.Size(176, 22)
        Me.bookTitle.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Book Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Book Records"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Details:"
        '
        'titleTxtbox
        '
        Me.titleTxtbox.Location = New System.Drawing.Point(12, 105)
        Me.titleTxtbox.Name = "titleTxtbox"
        Me.titleTxtbox.Size = New System.Drawing.Size(176, 22)
        Me.titleTxtbox.TabIndex = 2
        '
        'authorTxtbox
        '
        Me.authorTxtbox.Location = New System.Drawing.Point(12, 178)
        Me.authorTxtbox.Name = "authorTxtbox"
        Me.authorTxtbox.Size = New System.Drawing.Size(176, 22)
        Me.authorTxtbox.TabIndex = 2
        '
        'genreTxtbox
        '
        Me.genreTxtbox.Location = New System.Drawing.Point(12, 255)
        Me.genreTxtbox.Name = "genreTxtbox"
        Me.genreTxtbox.Size = New System.Drawing.Size(176, 22)
        Me.genreTxtbox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Author:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Genre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Book Status:"
        '
        'bookStatus
        '
        Me.bookStatus.FormattingEnabled = True
        Me.bookStatus.Location = New System.Drawing.Point(12, 333)
        Me.bookStatus.Name = "bookStatus"
        Me.bookStatus.Size = New System.Drawing.Size(176, 24)
        Me.bookStatus.TabIndex = 3
        '
        'addButon
        '
        Me.addButon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButon.Location = New System.Drawing.Point(5, 414)
        Me.addButon.Name = "addButon"
        Me.addButon.Size = New System.Drawing.Size(106, 32)
        Me.addButon.TabIndex = 4
        Me.addButon.Text = "Add Book"
        Me.addButon.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayButton.Location = New System.Drawing.Point(117, 414)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(106, 32)
        Me.displayButton.TabIndex = 4
        Me.displayButton.Text = "Display Info"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(5, 465)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(106, 32)
        Me.editButton.TabIndex = 4
        Me.editButton.Text = "Edit Info"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(117, 465)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(106, 32)
        Me.deleteButton.TabIndex = 4
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.addButon)
        Me.Controls.Add(Me.bookStatus)
        Me.Controls.Add(Me.genreTxtbox)
        Me.Controls.Add(Me.authorTxtbox)
        Me.Controls.Add(Me.titleTxtbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents titleTxtbox As TextBox
    Friend WithEvents authorTxtbox As TextBox
    Friend WithEvents genreTxtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bookStatus As ComboBox
    Friend WithEvents addButon As Button
    Friend WithEvents bookCondition As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bookGenre As TextBox
    Friend WithEvents bookAuthor As TextBox
    Friend WithEvents bookTitle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents displayButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label12 As Label
End Class
