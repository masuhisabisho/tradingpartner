'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 20:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class RegOrder
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.textBox7 = New System.Windows.Forms.TextBox()
		Me.textBox8 = New System.Windows.Forms.TextBox()
		Me.textBox9 = New System.Windows.Forms.TextBox()
		Me.textBox10 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.button5 = New System.Windows.Forms.Button()
		Me.button6 = New System.Windows.Forms.Button()
		Me.label11 = New System.Windows.Forms.Label()
		Me.textBox11 = New System.Windows.Forms.TextBox()
		Me.button7 = New System.Windows.Forms.Button()
		Me.button8 = New System.Windows.Forms.Button()
		Me.button9 = New System.Windows.Forms.Button()
		Me.button10 = New System.Windows.Forms.Button()
		Me.button11 = New System.Windows.Forms.Button()
		Me.button12 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.Navy
		Me.label1.ForeColor = System.Drawing.Color.Yellow
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Date："
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.Navy
		Me.label2.ForeColor = System.Drawing.Color.Yellow
		Me.label2.Location = New System.Drawing.Point(12, 118)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "P/I No.："
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.Color.Navy
		Me.label3.ForeColor = System.Drawing.Color.Yellow
		Me.label3.Location = New System.Drawing.Point(12, 81)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "P/O No.："
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.Color.Navy
		Me.label4.ForeColor = System.Drawing.Color.Yellow
		Me.label4.Location = New System.Drawing.Point(12, 193)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Shipping Time："
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label5
		'
		Me.label5.BackColor = System.Drawing.Color.Navy
		Me.label5.ForeColor = System.Drawing.Color.Yellow
		Me.label5.Location = New System.Drawing.Point(12, 46)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 4
		Me.label5.Text = "Acc No.："
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.Color.Navy
		Me.label6.ForeColor = System.Drawing.Color.Yellow
		Me.label6.Location = New System.Drawing.Point(12, 234)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 5
		Me.label6.Text = "Shipping Unit："
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label7
		'
		Me.label7.BackColor = System.Drawing.Color.Navy
		Me.label7.ForeColor = System.Drawing.Color.Yellow
		Me.label7.Location = New System.Drawing.Point(12, 271)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 6
		Me.label7.Text = "Payment Terms.："
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label8
		'
		Me.label8.BackColor = System.Drawing.Color.Navy
		Me.label8.ForeColor = System.Drawing.Color.Yellow
		Me.label8.Location = New System.Drawing.Point(12, 309)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 23)
		Me.label8.TabIndex = 7
		Me.label8.Text = "Price："
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label9
		'
		Me.label9.BackColor = System.Drawing.Color.Navy
		Me.label9.ForeColor = System.Drawing.Color.Yellow
		Me.label9.Location = New System.Drawing.Point(12, 350)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 8
		Me.label9.Text = "Shiping Item："
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label10
		'
		Me.label10.BackColor = System.Drawing.Color.Navy
		Me.label10.ForeColor = System.Drawing.Color.Yellow
		Me.label10.Location = New System.Drawing.Point(12, 154)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 9
		Me.label10.Text = "Inv No.："
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'textBox1
		'
		Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox1.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox1.Location = New System.Drawing.Point(137, 9)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(100, 23)
		Me.textBox1.TabIndex = 10
		'
		'textBox2
		'
		Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox2.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox2.Location = New System.Drawing.Point(137, 45)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(100, 23)
		Me.textBox2.TabIndex = 11
		'
		'textBox3
		'
		Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox3.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox3.Location = New System.Drawing.Point(137, 81)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(100, 23)
		Me.textBox3.TabIndex = 12
		'
		'textBox4
		'
		Me.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox4.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox4.Location = New System.Drawing.Point(137, 118)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(100, 23)
		Me.textBox4.TabIndex = 13
		'
		'textBox5
		'
		Me.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox5.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox5.Location = New System.Drawing.Point(137, 154)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(100, 23)
		Me.textBox5.TabIndex = 14
		'
		'textBox6
		'
		Me.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox6.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox6.Location = New System.Drawing.Point(137, 193)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(100, 23)
		Me.textBox6.TabIndex = 15
		'
		'textBox7
		'
		Me.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox7.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox7.Location = New System.Drawing.Point(137, 234)
		Me.textBox7.Name = "textBox7"
		Me.textBox7.Size = New System.Drawing.Size(100, 23)
		Me.textBox7.TabIndex = 16
		'
		'textBox8
		'
		Me.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox8.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox8.Location = New System.Drawing.Point(137, 271)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.Size = New System.Drawing.Size(100, 23)
		Me.textBox8.TabIndex = 17
		'
		'textBox9
		'
		Me.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox9.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox9.Location = New System.Drawing.Point(137, 308)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(100, 23)
		Me.textBox9.TabIndex = 18
		'
		'textBox10
		'
		Me.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox10.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox10.Location = New System.Drawing.Point(137, 349)
		Me.textBox10.Name = "textBox10"
		Me.textBox10.Size = New System.Drawing.Size(100, 23)
		Me.textBox10.TabIndex = 19
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(452, 190)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(115, 43)
		Me.button1.TabIndex = 20
		Me.button1.Text = "メーカー発注"
		Me.button1.UseVisualStyleBackColor = true
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(452, 68)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(115, 43)
		Me.button2.TabIndex = 21
		Me.button2.Text = "船積書類発行"
		Me.button2.UseVisualStyleBackColor = true
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(452, 126)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(115, 43)
		Me.button3.TabIndex = 22
		Me.button3.Text = "S/I作成"
		Me.button3.UseVisualStyleBackColor = true
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(452, 9)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(115, 43)
		Me.button4.TabIndex = 23
		Me.button4.Text = "P/I発行"
		Me.button4.UseVisualStyleBackColor = true
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(452, 248)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(115, 43)
		Me.button5.TabIndex = 24
		Me.button5.Text = "搬入リスト発行"
		Me.button5.UseVisualStyleBackColor = true
		'
		'button6
		'
		Me.button6.Location = New System.Drawing.Point(452, 306)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(115, 43)
		Me.button6.TabIndex = 25
		Me.button6.Text = "GSP申請書作成"
		Me.button6.UseVisualStyleBackColor = true
		'
		'label11
		'
		Me.label11.BackColor = System.Drawing.Color.Navy
		Me.label11.ForeColor = System.Drawing.Color.Yellow
		Me.label11.Location = New System.Drawing.Point(12, 396)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 26
		Me.label11.Text = "L/C No.："
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'textBox11
		'
		Me.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox11.Font = New System.Drawing.Font("MS UI Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.textBox11.Location = New System.Drawing.Point(137, 396)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(100, 23)
		Me.textBox11.TabIndex = 27
		'
		'button7
		'
		Me.button7.Location = New System.Drawing.Point(452, 376)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(115, 43)
		Me.button7.TabIndex = 28
		Me.button7.Text = "ケースマーク採番"
		Me.button7.UseVisualStyleBackColor = true
		'
		'button8
		'
		Me.button8.Location = New System.Drawing.Point(259, 46)
		Me.button8.Name = "button8"
		Me.button8.Size = New System.Drawing.Size(61, 23)
		Me.button8.TabIndex = 29
		Me.button8.Text = "自動採番"
		Me.button8.UseVisualStyleBackColor = true
		'
		'button9
		'
		Me.button9.Location = New System.Drawing.Point(259, 82)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(61, 23)
		Me.button9.TabIndex = 30
		Me.button9.Text = "自動採番"
		Me.button9.UseVisualStyleBackColor = true
		'
		'button10
		'
		Me.button10.Location = New System.Drawing.Point(259, 118)
		Me.button10.Name = "button10"
		Me.button10.Size = New System.Drawing.Size(61, 23)
		Me.button10.TabIndex = 31
		Me.button10.Text = "自動採番"
		Me.button10.UseVisualStyleBackColor = true
		'
		'button11
		'
		Me.button11.Location = New System.Drawing.Point(259, 155)
		Me.button11.Name = "button11"
		Me.button11.Size = New System.Drawing.Size(61, 23)
		Me.button11.TabIndex = 32
		Me.button11.Text = "自動採番"
		Me.button11.UseVisualStyleBackColor = true
		'
		'button12
		'
		Me.button12.Location = New System.Drawing.Point(259, 193)
		Me.button12.Name = "button12"
		Me.button12.Size = New System.Drawing.Size(61, 23)
		Me.button12.TabIndex = 33
		Me.button12.Text = "自動採番"
		Me.button12.UseVisualStyleBackColor = true
		'
		'RegOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(642, 452)
		Me.Controls.Add(Me.button12)
		Me.Controls.Add(Me.button11)
		Me.Controls.Add(Me.button10)
		Me.Controls.Add(Me.button9)
		Me.Controls.Add(Me.button8)
		Me.Controls.Add(Me.button7)
		Me.Controls.Add(Me.textBox11)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.button6)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBox10)
		Me.Controls.Add(Me.textBox9)
		Me.Controls.Add(Me.textBox8)
		Me.Controls.Add(Me.textBox7)
		Me.Controls.Add(Me.textBox6)
		Me.Controls.Add(Me.textBox5)
		Me.Controls.Add(Me.textBox4)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "RegOrder"
		Me.Text = "注文登録"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button12 As System.Windows.Forms.Button
	Private button11 As System.Windows.Forms.Button
	Private button10 As System.Windows.Forms.Button
	Private button9 As System.Windows.Forms.Button
	Private button8 As System.Windows.Forms.Button
	Private button7 As System.Windows.Forms.Button
	Private textBox11 As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private button6 As System.Windows.Forms.Button
	Private button5 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private textBox10 As System.Windows.Forms.TextBox
	Private textBox9 As System.Windows.Forms.TextBox
	Private textBox8 As System.Windows.Forms.TextBox
	Private textBox7 As System.Windows.Forms.TextBox
	Private textBox6 As System.Windows.Forms.TextBox
	Private textBox5 As System.Windows.Forms.TextBox
	Private textBox4 As System.Windows.Forms.TextBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
