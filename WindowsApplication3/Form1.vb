Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMyTrip.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picPlaces.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub

    Private Sub btnCalgary_Click(sender As Object, e As EventArgs) Handles btnCalgary.Click
        Me.lblMyTrip.Text = "My Trip to Calgary"
        Me.lblDescription.Text = "Canada's Sports Hall of Fame"
        picPlaces.Image = My.Resources.Canada_s_Sports_Hall_of_Fame

    End Sub

    Private Sub btnEdmonton_Click(sender As Object, e As EventArgs) Handles btnEdmonton.Click
        Me.lblMyTrip.Text = "My Trip to Edmonton"
        Me.lblDescription.Text = "TELUS World of Science"
        picPlaces.Image = My.Resources.TELUS_World_of_Science
    End Sub

    Private Sub btnBanff_Click(sender As Object, e As EventArgs) Handles btnBanff.Click
        Me.lblMyTrip.Text = "My Trip to Banff"
        Me.lblDescription.Text = "The Banff Gondola going up to Sulphur Mountain"
        picPlaces.Image = My.Resources.Sulphur_Mountain

    End Sub

    Private Sub btnWinnipeg_Click(sender As Object, e As EventArgs) Handles btnWinnipeg.Click
        Me.lblMyTrip.Text = "My Trip to Winnipeg"
        Me.lblDescription.Text = "The Human Rights Muesuem and Provencher Bridge at the Forks"
        picPlaces.Image = My.Resources.The_Forks

    End Sub

    Private Sub btnMars_Click(sender As Object, e As EventArgs) Handles btnMars.Click
        Me.lblMyTrip.Text = "My Trip to Mars"
        Me.lblDescription.Text = "View of Mars from Space"
        picPlaces.Image = My.Resources.Mars
    End Sub
End Class
