Public Class Form1

    Dim DecNo1, DecNo2, DecResult As Decimal
    Dim IntNo1, IntNo2, IntResult As Integer

    'use Messagebox.show(Err.number) when you want to show the error's number &
    'Messagebox.show(Err.description) when you want to show the error's description

    Private Sub BtnDivisionWithRemainder_Click(sender As Object, e As EventArgs) Handles BtnDivisionWithRemainder.Click
        Try
            DecNo1 = txtNum1.Text
            DecNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        DecResult = DecNo1 / DecNo2
        txtResult.Text = DecResult
    End Sub

    Private Sub btnDivisionNoRemainder_Click(sender As Object, e As EventArgs) Handles btnDivisionNoRemainder.Click
        Try
            IntNo1 = txtNum1.Text
            IntNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = IntNo1 \ IntNo2
        txtResult.Text = IntResult
    End Sub

    Private Sub btnModulous_Click(sender As Object, e As EventArgs) Handles btnModulous.Click
        Try
            IntNo1 = txtNum1.Text
            IntNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = IntNo1 Mod IntNo2
        txtResult.Text = IntResult
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtResult.Text = ""
        txtNum1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Try
            IntNo1 = txtNum1.Text
            IntNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = Math.Pow(IntNo1, IntNo2)
        txtResult.Text = IntResult
    End Sub

    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        Try
            IntNo1 = txtNum1.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = Math.Sqrt(IntNo1)
        txtResult.Text = IntResult
    End Sub

    Private Sub btnCeiling_Click(sender As Object, e As EventArgs) Handles btnCeiling.Click
        Try
            DecNo1 = txtNum1.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = Math.Ceiling(DecNo1)
        txtResult.Text = IntResult
    End Sub

    Private Sub btnFloor_Click(sender As Object, e As EventArgs) Handles btnFloor.Click
        Try
            DecNo1 = txtNum1.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = Math.Floor(DecNo1)
        txtResult.Text = IntResult
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Try
            DecNo1 = txtNum1.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        If (IntNo1 > IntNo2) Then
            IntResult = IntNo1
        Else
            IntResult = IntNo2
        End If
        txtResult.Text = IntResult
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Try
            IntNo1 = txtNum1.Text
            IntNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = IntNo1 * IntNo2
        txtResult.Text = IntResult
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        Try
            IntNo1 = txtNum1.Text
            IntNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = IntNo1 - IntNo2
        txtResult.Text = IntResult
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Try
            IntNo1 = txtNum1.Text
            IntNo2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Please only Enter Numerical Values.", "Input Error")
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtResult.Text = ""
            txtNum1.Focus()
        End Try

        IntResult = IntNo1 + IntNo2
        txtResult.Text = IntResult
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
