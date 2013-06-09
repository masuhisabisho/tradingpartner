'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 15:17
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
'Imports System.Deployment.Application

Public Partial Class Login
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	Sub LoginLoad(Byval sender As Object, Byval e As EventArgs)
'	'プログラムの更新チェック
'        If ApplicationDeployment.IsNetworkDeployed Then
'            If ApplicationDeployment.CurrentDeployment.CheckForUpdate() Then
'                Dim deploy As ApplicationDeployment
'                deploy = ApplicationDeployment.CurrentDeployment
'                deploy.Update()
'                MessageBox.Show("更新を終了しました。")
'                End
'            End If
'        End If
'
'        'バージョン情報を表示
'        最終更新日.Text = System.IO.File.GetLastWriteTime(Application.StartupPath).ToString("yyyy/MM/dd HH:mm")
'        メッセージ.Text = ""

	'Set forcus on password
	Me.Txt_Password.TabIndex = 0
	Me.Txt_Password.Focus()
	Me.Focus()
	
	'TODO: Login check
	
	'TODO: Set enviroment parameters
	
	'TODO: Set latest login data on db
	
	'TODO: Call instance
	
	'my computer -> property -> machine name Dim str As String = System.Environment.MachineName.ToString()
	
	'TODO: Auto login
	
	End Sub
	

End Class
