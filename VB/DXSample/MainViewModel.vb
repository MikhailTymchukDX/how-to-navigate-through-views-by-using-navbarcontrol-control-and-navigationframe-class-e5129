Imports DevExpress.Xpf.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DXSample
	Public Class MainViewModel
		Inherits ViewModelBase

		Private privateOnViewLoadedCommand As ICommand
		Public Property OnViewLoadedCommand() As ICommand
			Get
				Return privateOnViewLoadedCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateOnViewLoadedCommand = value
			End Set
		End Property
		Private privateGoToUserControl1Command As ICommand
		Public Property GoToUserControl1Command() As ICommand
			Get
				Return privateGoToUserControl1Command
			End Get
			Private Set(ByVal value As ICommand)
				privateGoToUserControl1Command = value
			End Set
		End Property
		Private privateGoToUserControl2Command As ICommand
		Public Property GoToUserControl2Command() As ICommand
			Get
				Return privateGoToUserControl2Command
			End Get
			Private Set(ByVal value As ICommand)
				privateGoToUserControl2Command = value
			End Set
		End Property
		Private privateGoToUserControl3Command As ICommand
		Public Property GoToUserControl3Command() As ICommand
			Get
				Return privateGoToUserControl3Command
			End Get
			Private Set(ByVal value As ICommand)
				privateGoToUserControl3Command = value
			End Set
		End Property
		Public Sub New()
			OnViewLoadedCommand = New DelegateCommand(AddressOf OnNavigateDetailsCommandExecute)
			GoToUserControl1Command = New DelegateCommand(AddressOf GoToUserControl1CommandExecute)
			GoToUserControl2Command = New DelegateCommand(AddressOf GoToUserControl2CommandExecute)
			GoToUserControl3Command = New DelegateCommand(AddressOf GoToUserControl3CommandExecute)

		End Sub
		Private Sub OnNavigateDetailsCommandExecute()
			'Navigate to the HomeView.
			ServiceContainer.GetService(Of INavigationService)().Navigate("HomeView", Nothing, Me)
		End Sub
		Private Sub GoToUserControl1CommandExecute()
			ServiceContainer.GetService(Of INavigationService)().Navigate("UserControl1", Nothing, Me)
		End Sub
		Private Sub GoToUserControl2CommandExecute()
			ServiceContainer.GetService(Of INavigationService)().Navigate("UserControl2", Nothing, Me)
		End Sub
		Private Sub GoToUserControl3CommandExecute()
			ServiceContainer.GetService(Of INavigationService)().Navigate("UserControl3", Nothing, Me)
		End Sub
	End Class
End Namespace
