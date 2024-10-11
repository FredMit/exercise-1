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
        btnClick = New Button()
        lblName = New Label()
        lblAge = New Label()
        lblFavouriteColor = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtColor = New TextBox()
        SuspendLayout()
        ' 
        ' btnClick
        ' 
        btnClick.Location = New Point(93, 127)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(75, 23)
        btnClick.TabIndex = 0
        btnClick.Text = "CLICK"
        btnClick.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(93, 32)
        lblName.Name = "lblName"
        lblName.Size = New Size(41, 15)
        lblName.TabIndex = 1
        lblName.Text = "NAME"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(93, 65)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(29, 15)
        lblAge.TabIndex = 2
        lblAge.Text = "AGE"
        ' 
        ' lblFavouriteColor
        ' 
        lblFavouriteColor.AutoSize = True
        lblFavouriteColor.Location = New Point(27, 89)
        lblFavouriteColor.Name = "lblFavouriteColor"
        lblFavouriteColor.Size = New Size(107, 15)
        lblFavouriteColor.TabIndex = 3
        lblFavouriteColor.Text = "FAVOURITE COLOR"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(140, 24)
        txtName.Name = "txtName"
        txtName.Size = New Size(265, 23)
        txtName.TabIndex = 4
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(140, 53)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(265, 23)
        txtAge.TabIndex = 5
        ' 
        ' txtColor
        ' 
        txtColor.Location = New Point(140, 82)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(265, 23)
        txtColor.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(646, 228)
        Controls.Add(txtColor)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(lblFavouriteColor)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Controls.Add(btnClick)
        Name = "Form1"
        Text = "Exercise1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblFavouriteColor As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtColor As TextBox

End Class
