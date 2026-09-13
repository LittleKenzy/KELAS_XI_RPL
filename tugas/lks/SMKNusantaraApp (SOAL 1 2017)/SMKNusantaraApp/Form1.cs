namespace SMKNusantaraApp
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            // Biarkan kosong seperti ini
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = Database.DB.Users.FirstOrDefault(u => u.Username == usernameTxt.Text && u.Password == passwordTxt.Text);

            if (user != null)
            {
                MessageBox.Show($"Login berhasil! Selamat datang {user.Username}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hilangkan spasi dan ubah ke huruf kecil semua untuk memastikan kecocokan
                string userRole = user.Role?.Trim().ToLower();

                if (userRole == "admin")
                {
                    AdminNavigationForm adminForm = new AdminNavigationForm();
                    this.Hide(); // Sembunyikan form login terlebih dahulu
                    adminForm.Show(); // Baru tampilkan form admin
                }
                else if (userRole == "teacher")
                {
                    // TeacherNavigationForm teacherForm = new TeacherNavigationForm();
                    // this.Hide();
                    // teacherForm.Show();
                }
                else if (userRole == "student")
                {
                    // StudentNavigationForm studentForm = new StudentNavigationForm();
                    // this.Hide();
                    // studentForm.Show();
                }
                else
                {
                    // Jika role di database ternyata bukan Admin/Teacher/Student
                    MessageBox.Show($"Role pengguna '{user.Role}' tidak dikenali oleh sistem.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Usenrame atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
