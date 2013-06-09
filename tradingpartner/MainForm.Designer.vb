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
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox1.Location = New System.Drawing.Point(188, 100)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.textBox1.Size = New System.Drawing.Size(162, 26)
		Me.textBox1.TabIndex = 0
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(378, 99)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 27)
		Me.button1.TabIndex = 1
		Me.button1.Text = "button1"
		Me.button1.UseVisualStyleBackColor = true
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label1.Location = New System.Drawing.Point(50, 213)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 2
		Me.label1.Text = "label1"
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label2.Location = New System.Drawing.Point(169, 213)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "label2"
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label3.Location = New System.Drawing.Point(298, 213)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 4
		Me.label3.Text = "label3"
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label4.Location = New System.Drawing.Point(423, 213)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 5
		Me.label4.Text = "label4"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(552, 285)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBox1)
		Me.Name = "MainForm"
		Me.Text = "ログイン"
		AddHandler Load, AddressOf Me.LoginLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private textBox1 As System.Windows.Forms.TextBox
End Class
