Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(6, 266)
        Cursor.Position = PointToScreen(StartingPoint)


    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label163.MouseEnter, Panel1.MouseEnter, Label1.MouseHover, Label3.MouseHover, Label2.MouseHover
        MoveToStart()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()


    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) _
                                               Handles Panel1.MouseDown
        Panel1.Capture = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class