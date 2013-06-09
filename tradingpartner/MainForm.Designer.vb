'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 15:17
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.Txt_Password = New System.Windows.Forms.TextBox()
		Me.Brn_Login = New System.Windows.Forms.Button()
		Me.Lbl_Ver = New System.Windows.Forms.Label()
		Me.Lbl_VerNo = New System.Windows.Forms.Label()
		Me.Lbl_Update = New System.Windows.Forms.Label()
		Me.Lbl_Date = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'Txt_Password
		'
		Me.Txt_Password.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.Txt_Password.Location = New System.Drawing.Point(165, 83)
		Me.Txt_Password.Name = "Txt_Password"
		Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.Txt_Password.Size = New System.Drawing.Size(162, 26)
		Me.Txt_Password.TabIndex = 0
		'
		'Brn_Login
		'
		Me.Brn_Login.Location = New System.Drawing.Point(355, 82)
		Me.Brn_Login.Name = "Brn_Login"
		Me.Brn_Login.Size = New System.Drawing.Size(75, 27)
		Me.Brn_Login.TabIndex = 1
		Me.Brn_Login.Text = "ログイン"
		Me.Brn_Login.UseVisualStyleBackColor = true
		'
		'Lbl_Ver
		'
		Me.Lbl_Ver.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Lbl_Ver.Location = New System.Drawing.Point(168, 196)
		Me.Lbl_Ver.Name = "Lbl_Ver"
		Me.Lbl_Ver.Size = New System.Drawing.Size(50, 14)
		Me.Lbl_Ver.TabIndex = 2
		Me.Lbl_Ver.Text = "バージョン"
		'
		'Lbl_VerNo
		'
		Me.Lbl_VerNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Lbl_VerNo.Location = New System.Drawing.Point(224, 196)
		Me.Lbl_VerNo.Name = "Lbl_VerNo"
		Me.Lbl_VerNo.Size = New System.Drawing.Size(38, 14)
		Me.Lbl_VerNo.TabIndex = 3
		Me.Lbl_VerNo.Text = "0.0.0.0"
		'
		'Lbl_Update
		'
		Me.Lbl_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Lbl_Update.Location = New System.Drawing.Point(316, 196)
		Me.Lbl_Update.Name = "Lbl_Update"
		Me.Lbl_Update.Size = New System.Drawing.Size(88, 14)
		Me.Lbl_Update.TabIndex = 4
		Me.Lbl_Update.Text = "最終更新日時:"
		'
		'Lbl_Date
		'
		Me.Lbl_Date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Lbl_Date.Location = New System.Drawing.Point(409, 196)
		Me.Lbl_Date.Name = "Lbl_Date"
		Me.Lbl_Date.Size = New System.Drawing.Size(100, 14)
		Me.Lbl_Date.TabIndex = 5
		Me.Lbl_Date.Text = "0000/00/00 00:00"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(516, 222)
		Me.Controls.Add(Me.Lbl_Date)
		Me.Controls.Add(Me.Lbl_Update)
		Me.Controls.Add(Me.Lbl_VerNo)
		Me.Controls.Add(Me.Lbl_Ver)
		Me.Controls.Add(Me.Brn_Login)
		Me.Controls.Add(Me.Txt_Password)
		Me.Name = "MainForm"
		Me.Text = "ログイン"
		AddHandler Load, AddressOf Me.LoginLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private Txt_Password As System.Windows.Forms.TextBox
	Private Brn_Login As System.Windows.Forms.Button
	Private Lbl_Ver As System.Windows.Forms.Label
	Private Lbl_VerNo As System.Windows.Forms.Label
	Private Lbl_Update As System.Windows.Forms.Label
	Private Lbl_Date As System.Windows.Forms.Label
End Class
