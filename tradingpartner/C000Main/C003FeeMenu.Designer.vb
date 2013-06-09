'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 20:04
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class C003FeeMenu
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
		Me.Tlp_Main = New System.Windows.Forms.TableLayoutPanel()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.button8 = New System.Windows.Forms.Button()
		Me.button7 = New System.Windows.Forms.Button()
		Me.button6 = New System.Windows.Forms.Button()
		Me.button5 = New System.Windows.Forms.Button()
		Me.button12 = New System.Windows.Forms.Button()
		Me.button11 = New System.Windows.Forms.Button()
		Me.button10 = New System.Windows.Forms.Button()
		Me.button9 = New System.Windows.Forms.Button()
		Me.button16 = New System.Windows.Forms.Button()
		Me.button15 = New System.Windows.Forms.Button()
		Me.button14 = New System.Windows.Forms.Button()
		Me.button13 = New System.Windows.Forms.Button()
		Me.button20 = New System.Windows.Forms.Button()
		Me.button19 = New System.Windows.Forms.Button()
		Me.button18 = New System.Windows.Forms.Button()
		Me.button17 = New System.Windows.Forms.Button()
		Me.button24 = New System.Windows.Forms.Button()
		Me.button23 = New System.Windows.Forms.Button()
		Me.button22 = New System.Windows.Forms.Button()
		Me.button21 = New System.Windows.Forms.Button()
		Me.Tlp_Main.SuspendLayout
		Me.SuspendLayout
		'
		'Tlp_Main
		'
		Me.Tlp_Main.ColumnCount = 4
		Me.Tlp_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
		Me.Tlp_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
		Me.Tlp_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
		Me.Tlp_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
		Me.Tlp_Main.Controls.Add(Me.button17, 0, 4)
		Me.Tlp_Main.Controls.Add(Me.button18, 1, 4)
		Me.Tlp_Main.Controls.Add(Me.button24, 3, 5)
		Me.Tlp_Main.Controls.Add(Me.button23, 2, 5)
		Me.Tlp_Main.Controls.Add(Me.button22, 1, 5)
		Me.Tlp_Main.Controls.Add(Me.button19, 2, 4)
		Me.Tlp_Main.Controls.Add(Me.button14, 1, 3)
		Me.Tlp_Main.Controls.Add(Me.button13, 0, 3)
		Me.Tlp_Main.Controls.Add(Me.button20, 3, 4)
		Me.Tlp_Main.Controls.Add(Me.button15, 2, 3)
		Me.Tlp_Main.Controls.Add(Me.button10, 1, 2)
		Me.Tlp_Main.Controls.Add(Me.button9, 0, 2)
		Me.Tlp_Main.Controls.Add(Me.button16, 3, 3)
		Me.Tlp_Main.Controls.Add(Me.button6, 1, 1)
		Me.Tlp_Main.Controls.Add(Me.button11, 2, 2)
		Me.Tlp_Main.Controls.Add(Me.button7, 2, 1)
		Me.Tlp_Main.Controls.Add(Me.button8, 3, 1)
		Me.Tlp_Main.Controls.Add(Me.button12, 3, 2)
		Me.Tlp_Main.Controls.Add(Me.button3, 2, 0)
		Me.Tlp_Main.Controls.Add(Me.button21, 0, 5)
		Me.Tlp_Main.Controls.Add(Me.button5, 0, 1)
		Me.Tlp_Main.Controls.Add(Me.button1, 0, 0)
		Me.Tlp_Main.Controls.Add(Me.button4, 3, 0)
		Me.Tlp_Main.Controls.Add(Me.button2, 1, 0)
		Me.Tlp_Main.Location = New System.Drawing.Point(4, 3)
		Me.Tlp_Main.Name = "Tlp_Main"
		Me.Tlp_Main.RowCount = 6
		Me.Tlp_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70513!))
		Me.Tlp_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.6282!))
		Me.Tlp_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.Tlp_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.Tlp_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.Tlp_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.Tlp_Main.Size = New System.Drawing.Size(700, 312)
		Me.Tlp_Main.TabIndex = 2
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(3, 3)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(167, 43)
		Me.button1.TabIndex = 24
		Me.button1.Text = "button1"
		Me.button1.UseVisualStyleBackColor = true
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(178, 3)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(167, 43)
		Me.button2.TabIndex = 25
		Me.button2.Text = "button2"
		Me.button2.UseVisualStyleBackColor = true
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(353, 3)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(167, 43)
		Me.button3.TabIndex = 26
		Me.button3.Text = "button3"
		Me.button3.UseVisualStyleBackColor = true
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(528, 3)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(167, 43)
		Me.button4.TabIndex = 27
		Me.button4.Text = "button4"
		Me.button4.UseVisualStyleBackColor = true
		'
		'button8
		'
		Me.button8.Location = New System.Drawing.Point(528, 52)
		Me.button8.Name = "button8"
		Me.button8.Size = New System.Drawing.Size(167, 49)
		Me.button8.TabIndex = 28
		Me.button8.Text = "button8"
		Me.button8.UseVisualStyleBackColor = true
		'
		'button7
		'
		Me.button7.Location = New System.Drawing.Point(353, 52)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(167, 49)
		Me.button7.TabIndex = 29
		Me.button7.Text = "button7"
		Me.button7.UseVisualStyleBackColor = true
		'
		'button6
		'
		Me.button6.Location = New System.Drawing.Point(178, 52)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(167, 49)
		Me.button6.TabIndex = 30
		Me.button6.Text = "button6"
		Me.button6.UseVisualStyleBackColor = true
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(3, 52)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(167, 49)
		Me.button5.TabIndex = 31
		Me.button5.Text = "button5"
		Me.button5.UseVisualStyleBackColor = true
		'
		'button12
		'
		Me.button12.Location = New System.Drawing.Point(528, 107)
		Me.button12.Name = "button12"
		Me.button12.Size = New System.Drawing.Size(167, 46)
		Me.button12.TabIndex = 32
		Me.button12.Text = "button12"
		Me.button12.UseVisualStyleBackColor = true
		'
		'button11
		'
		Me.button11.Location = New System.Drawing.Point(353, 107)
		Me.button11.Name = "button11"
		Me.button11.Size = New System.Drawing.Size(167, 46)
		Me.button11.TabIndex = 33
		Me.button11.Text = "button11"
		Me.button11.UseVisualStyleBackColor = true
		'
		'button10
		'
		Me.button10.Location = New System.Drawing.Point(178, 107)
		Me.button10.Name = "button10"
		Me.button10.Size = New System.Drawing.Size(167, 46)
		Me.button10.TabIndex = 34
		Me.button10.Text = "button10"
		Me.button10.UseVisualStyleBackColor = true
		'
		'button9
		'
		Me.button9.Location = New System.Drawing.Point(3, 107)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(167, 46)
		Me.button9.TabIndex = 35
		Me.button9.Text = "button9"
		Me.button9.UseVisualStyleBackColor = true
		'
		'button16
		'
		Me.button16.Location = New System.Drawing.Point(528, 159)
		Me.button16.Name = "button16"
		Me.button16.Size = New System.Drawing.Size(167, 46)
		Me.button16.TabIndex = 36
		Me.button16.Text = "button16"
		Me.button16.UseVisualStyleBackColor = true
		'
		'button15
		'
		Me.button15.Location = New System.Drawing.Point(353, 159)
		Me.button15.Name = "button15"
		Me.button15.Size = New System.Drawing.Size(167, 46)
		Me.button15.TabIndex = 37
		Me.button15.Text = "button15"
		Me.button15.UseVisualStyleBackColor = true
		'
		'button14
		'
		Me.button14.Location = New System.Drawing.Point(178, 159)
		Me.button14.Name = "button14"
		Me.button14.Size = New System.Drawing.Size(167, 46)
		Me.button14.TabIndex = 38
		Me.button14.Text = "button14"
		Me.button14.UseVisualStyleBackColor = true
		'
		'button13
		'
		Me.button13.Location = New System.Drawing.Point(3, 159)
		Me.button13.Name = "button13"
		Me.button13.Size = New System.Drawing.Size(167, 46)
		Me.button13.TabIndex = 39
		Me.button13.Text = "button13"
		Me.button13.UseVisualStyleBackColor = true
		'
		'button20
		'
		Me.button20.Location = New System.Drawing.Point(528, 211)
		Me.button20.Name = "button20"
		Me.button20.Size = New System.Drawing.Size(167, 46)
		Me.button20.TabIndex = 40
		Me.button20.Text = "button20"
		Me.button20.UseVisualStyleBackColor = true
		'
		'button19
		'
		Me.button19.Location = New System.Drawing.Point(353, 211)
		Me.button19.Name = "button19"
		Me.button19.Size = New System.Drawing.Size(167, 46)
		Me.button19.TabIndex = 41
		Me.button19.Text = "button19"
		Me.button19.UseVisualStyleBackColor = true
		'
		'button18
		'
		Me.button18.Location = New System.Drawing.Point(178, 211)
		Me.button18.Name = "button18"
		Me.button18.Size = New System.Drawing.Size(167, 46)
		Me.button18.TabIndex = 42
		Me.button18.Text = "button18"
		Me.button18.UseVisualStyleBackColor = true
		'
		'button17
		'
		Me.button17.Location = New System.Drawing.Point(3, 211)
		Me.button17.Name = "button17"
		Me.button17.Size = New System.Drawing.Size(167, 46)
		Me.button17.TabIndex = 43
		Me.button17.Text = "button17"
		Me.button17.UseVisualStyleBackColor = true
		'
		'button24
		'
		Me.button24.Location = New System.Drawing.Point(528, 263)
		Me.button24.Name = "button24"
		Me.button24.Size = New System.Drawing.Size(167, 46)
		Me.button24.TabIndex = 44
		Me.button24.Text = "button24"
		Me.button24.UseVisualStyleBackColor = true
		'
		'button23
		'
		Me.button23.Location = New System.Drawing.Point(353, 263)
		Me.button23.Name = "button23"
		Me.button23.Size = New System.Drawing.Size(167, 46)
		Me.button23.TabIndex = 45
		Me.button23.Text = "button23"
		Me.button23.UseVisualStyleBackColor = true
		'
		'button22
		'
		Me.button22.Location = New System.Drawing.Point(178, 263)
		Me.button22.Name = "button22"
		Me.button22.Size = New System.Drawing.Size(167, 46)
		Me.button22.TabIndex = 46
		Me.button22.Text = "button22"
		Me.button22.UseVisualStyleBackColor = true
		'
		'button21
		'
		Me.button21.Location = New System.Drawing.Point(3, 263)
		Me.button21.Name = "button21"
		Me.button21.Size = New System.Drawing.Size(167, 46)
		Me.button21.TabIndex = 47
		Me.button21.Text = "button21"
		Me.button21.UseVisualStyleBackColor = true
		'
		'C003FeeMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 400)
		Me.Controls.Add(Me.Tlp_Main)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "C003FeeMenu"
		Me.Text = "C003FeeMenu"
		Me.Tlp_Main.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private button5 As System.Windows.Forms.Button
	Private button21 As System.Windows.Forms.Button
	Private button12 As System.Windows.Forms.Button
	Private button8 As System.Windows.Forms.Button
	Private button7 As System.Windows.Forms.Button
	Private button11 As System.Windows.Forms.Button
	Private button6 As System.Windows.Forms.Button
	Private button16 As System.Windows.Forms.Button
	Private button9 As System.Windows.Forms.Button
	Private button10 As System.Windows.Forms.Button
	Private button15 As System.Windows.Forms.Button
	Private button20 As System.Windows.Forms.Button
	Private button13 As System.Windows.Forms.Button
	Private button14 As System.Windows.Forms.Button
	Private button19 As System.Windows.Forms.Button
	Private button22 As System.Windows.Forms.Button
	Private button23 As System.Windows.Forms.Button
	Private button24 As System.Windows.Forms.Button
	Private button18 As System.Windows.Forms.Button
	Private button17 As System.Windows.Forms.Button
	Private Tlp_Main As System.Windows.Forms.TableLayoutPanel
	Private button2 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
End Class
