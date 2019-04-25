Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace DXApplication
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			BonusSkins.Register()
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier", "Office Colorful")
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
