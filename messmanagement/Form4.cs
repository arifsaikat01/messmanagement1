using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace messmanagement
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            // make sure your defaults actually run
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ShowDefaultPanels();
        }

        private void ShowDefaultPanels() // Add Member
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // container stays visible
            panelc2.Visible = false;    // hide deposit container
            panelc3.Visible = false;    // irrelevant when c2 is hidden
            panelc4.Visible = false;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panel4addmember.Visible = false;
            panel4createaddmem.Visible = false;
            panelc1.BringToFront();
        }

        private void ShowDeposit() // Deposit screen
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // keep parent visible
            panelc2.Visible = true;     // show deposit container
            panelc3.Visible = false;    // ensure change-manager overlay is hidden
            panelc4.Visible = false;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc2.BringToFront();
        }

        private void ShowChangeManager() // Change Manager screen
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // keep parent visible
            panelc2.Visible = true;     // parent of panelc3 must be visible
            panelc3.Visible = true;     // show overlay
            panelc4.Visible = false;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc3.BringToFront();
        }
        private void Showstartnewmonth() 
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     
            panelc2.Visible = true;     
            panelc3.Visible = true; 
            panelc4.Visible = true;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc4.BringToFront();
        }
        private void Deletemonth()
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc5.BringToFront();
        }
        private void Addmeal()
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = false;
            panelc6.BringToFront();
        }
        private void Addcost()
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = true;
            panelc7.BringToFront();
        }

        // wire buttons
        private void addmember_Click(object sender, EventArgs e) { 
            ShowDefaultPanels(); 
        }
        private void adddeposit_Click(object sender, EventArgs e) { 
            ShowDeposit(); 
        }
        private void changemanager_Click(object sender, EventArgs e) {
            ShowChangeManager(); 
        }
        private void newmonth_Click(object sender, EventArgs e)
        {
            Showstartnewmonth();
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            Deletemonth();
        }
        private void addmeal_Click(object sender, EventArgs e)
        {
            Addmeal();
        }
        private void addcost_Click(object sender, EventArgs e)
        {
            Addcost();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
       
        
        
        private void buttonaddmem_Click(object sender, EventArgs e)
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // container stays visible
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = true;
            panel4addmember.Visible = true;
            
            panel4addmember.BringToFront();
        }
        private void back4addmem_Click(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }
        private void buttoncreateadd_Click(object sender, EventArgs e)
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // container stays visible
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = true;
            panel4addmember.Visible = true;
            panel4createaddmem.Visible = true;  
            panel4createaddmem.BringToFront();
        }
        private void back4createadd_Click(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }

        private void dateTimePicker4diposit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4diposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4mem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butsubmit_Click(object sender, EventArgs e)
        {
            if (comboBox4mem.SelectedIndex < 0)
            {
                MessageBox.Show("Select a member.", "Missing member",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // parse amount robustly
            if (!decimal.TryParse(textBox4diposit.Text.Trim(),
                                  NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                                  CultureInfo.CurrentCulture,
                                  out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid positive deposit amount.", "Invalid amount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(((DataRowView)comboBox4mem.SelectedItem)["user_id"]);
            DateTime paidOn = dateTimePicker4diposit.Value.Date;

            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        // Ensure there is a period for the paidOn month (e.g., "2025-09")
                        string label = paidOn.ToString("yyyy-MM"); // adjust if you prefer "Sep-2025"
                        int periodId = GetOrCreatePeriod(conn, tx, CurrentMessId, label);

                        // Insert the deposit
                        using (var insert = new SqlCommand(@"
                            INSERT INTO dbo.Deposit(user_id, period_id, paid_on, amount)
                            VALUES (@u, @p, @d, @a);", conn, tx))
                        {
                            insert.Parameters.AddWithValue("@u", userId);
                            insert.Parameters.AddWithValue("@p", periodId);
                            insert.Parameters.AddWithValue("@d", paidOn);
                            insert.Parameters.AddWithValue("@a", amount);
                            insert.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                }

                MessageBox.Show("Deposit added.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // optional: clear amount textbox
                textBox4diposit.Clear();
                textBox4diposit.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4newmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub4newmonth_Click(object sender, EventArgs e)
        {

        }

        private void submitdelete_Click(object sender, EventArgs e)
        {

        }

        private void textBox4breakfastdef_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4lunchdef_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4dinnerdef_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitdefaultmeal_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4meal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void breakfastmeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lunchmeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dinnermeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4mealmem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public partial class FormAddMeal : Form4
        {
            // TODO: update with your real connection string
            private readonly string _connString = "Server=.;Database=MessDB;Trusted_Connection=True;TrustServerCertificate=True;";

            private readonly int CurrentMessId;

            public FormAddMeal(int messId)
            {
                this.InitializeComponent();
                CurrentMessId = messId;

                // load members when the form opens
                this.Load += (_, __) => LoadMembersSortedByName();
            }

            private void LoadMembersSortedByName()
            {
                using (var conn = new SqlConnection(_connString))
                using (var cmd = new SqlCommand(@"
                SELECT u.user_id, u.name
                FROM dbo.[User] u
                JOIN dbo.Membership m ON m.user_id = u.user_id
                WHERE m.mess_id = @mess AND m.left_at IS NULL
                ORDER BY u.name;", conn))
                {
                    cmd.Parameters.AddWithValue("@mess", CurrentMessId);
                    var dt = new DataTable();
                    conn.Open();
                    using (var r = cmd.ExecuteReader())
                        dt.Load(r);

                    comboBox4mealmem.DisplayMember = "name";
                    comboBox4mealmem.ValueMember = "user_id";
                    comboBox4mealmem.DataSource = dt;
                    comboBox4mealmem.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
                }
            }

            // ========================= MAIN HANDLER =========================
            // Wire your Submit button's Click event to this method name.
            private void submitmeal(object sender, EventArgs e)
            {
                if (comboBox4mealmem.SelectedIndex < 0)
                {
                    MessageBox.Show("Select a member.", "Missing member",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // parse integers; blank means 0
                if (!TryParseNonNegativeInt(breakfastmeal.Text, out int breakfast) ||
                    !TryParseNonNegativeInt(lunchmeal.Text, out int lunch) ||
                    !TryParseNonNegativeInt(dinnermeal.Text, out int dinner))
                {
                    MessageBox.Show("Breakfast, lunch and dinner must be whole numbers ≥ 0.",
                        "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = Convert.ToInt32(((DataRowView)comboBox4mealmem.SelectedItem)["user_id"]);
                DateTime forDate = dateTimePicker4meal.Value.Date;

                try
                {
                    using (var conn = new SqlConnection(_connString))
                    {
                        conn.Open();
                        using (var tx = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                        {
                            // ensure a period exists for this month (e.g., "yyyy-MM")
                            string label = forDate.ToString("yyyy-MM", CultureInfo.InvariantCulture);
                            int periodId = GetOrCreatePeriod(conn, tx, CurrentMessId, label);

                            // upsert meal entry for this user/date/period
                            using (var cmd = new SqlCommand(@"
                            IF EXISTS (
                                SELECT 1 FROM dbo.MealEntry
                                WHERE user_id=@u AND period_id=@p AND for_date=@d
                            )
                            BEGIN
                                UPDATE dbo.MealEntry
                                SET breakfast=@b, lunch=@l, dinner=@n
                                WHERE user_id=@u AND period_id=@p AND for_date=@d;
                            END
                            ELSE
                            BEGIN
                                INSERT INTO dbo.MealEntry(user_id, period_id, for_date, breakfast, lunch, dinner)
                                VALUES(@u, @p, @d, @b, @l, @n);
                            END
                            ", conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@u", userId);
                                cmd.Parameters.AddWithValue("@p", periodId);
                                cmd.Parameters.AddWithValue("@d", forDate);
                                cmd.Parameters.AddWithValue("@b", breakfast);
                                cmd.Parameters.AddWithValue("@l", lunch);
                                cmd.Parameters.AddWithValue("@n", dinner);
                                cmd.ExecuteNonQuery();
                            }

                            tx.Commit();
                        }
                    }

                    MessageBox.Show("Meal entry saved.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // optional: clear the small boxes for faster next entry
                    breakfastmeal.Text = lunchmeal.Text = dinnermeal.Text = "";
                    breakfastmeal.Focus();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // ========================= HELPERS =========================
            private static int GetOrCreatePeriod(SqlConnection conn, SqlTransaction tx, int messId, string label)
            {
                using (var sel = new SqlCommand(
                    @"SELECT period_id FROM dbo.Period WHERE mess_id=@m AND label=@l;", conn, tx))
                {
                    sel.Parameters.AddWithValue("@m", messId);
                    sel.Parameters.AddWithValue("@l", label);
                    object o = sel.ExecuteScalar();
                    if (o != null && o != DBNull.Value)
                        return Convert.ToInt32(o);
                }

                using (var ins = new SqlCommand(
                    @"INSERT INTO dbo.Period(mess_id, label)
                  VALUES(@m, @l);
                  SELECT SCOPE_IDENTITY();", conn, tx))
                {
                    ins.Parameters.AddWithValue("@m", messId);
                    ins.Parameters.AddWithValue("@l", label);
                    return Convert.ToInt32(ins.ExecuteScalar());
                }
            }

            private static bool TryParseNonNegativeInt(string s, out int value)
            {
                if (string.IsNullOrWhiteSpace(s)) { value = 0; return true; }
                if (int.TryParse(s.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture, out value) && value >= 0)
                    return true;
                value = 0; return false;
            }
        }

        

        private void dateTimePicker4mealcost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4mealcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4selectshoper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4mealcost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit4mealcost_Click(object sender, EventArgs e)
        {

        }

        private void textBox4addmem_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4addman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4addmem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private static int GetUserIdByEmail(SqlConnection conn, SqlTransaction tx, string email)
        {
            using (var cmd = new SqlCommand(
                @"SELECT user_id FROM dbo.[User] WHERE LOWER(email) = LOWER(@email);", conn, tx))
            {
                cmd.Parameters.AddWithValue("@email", email);
                var o = cmd.ExecuteScalar();
                return (o == null || o == DBNull.Value) ? 0 : Convert.ToInt32(o);
            }
        }

        private static int GetRoleId(SqlConnection conn, SqlTransaction tx, string roleName)
        {
            using (var cmd = new SqlCommand(
                @"SELECT role_id FROM dbo.Role WHERE role_name = @name;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@name", roleName);
                var o = cmd.ExecuteScalar();
                return (o == null || o == DBNull.Value) ? 0 : Convert.ToInt32(o);
            }
        }

        private static bool MessAlreadyHasManager(SqlConnection conn, SqlTransaction tx, int messId, int managerRoleId)
        {
            // UPDLOCK+HOLDLOCK prevents two parallel clicks from creating two managers
            using (var cmd = new SqlCommand(
                @"SELECT COUNT(*) 
                  FROM dbo.Membership WITH (UPDLOCK, HOLDLOCK)
                  WHERE mess_id = @mess_id AND role_id = @managerRoleId AND left_at IS NULL;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@mess_id", messId);
                cmd.Parameters.AddWithValue("@managerRoleId", managerRoleId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static bool HasActiveMembership(SqlConnection conn, SqlTransaction tx, int userId, int messId)
        {
            using (var cmd = new SqlCommand(
                @"SELECT COUNT(*) 
                  FROM dbo.Membership
                  WHERE user_id = @user_id AND mess_id = @mess_id AND left_at IS NULL;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@mess_id", messId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static void InsertMembership(SqlConnection conn, SqlTransaction tx, int userId, int messId, int roleId, DateTime joinedAt)
        {
            using (var cmd = new SqlCommand(
                @"INSERT INTO dbo.Membership(user_id, mess_id, role_id, joined_at, left_at)
                  VALUES(@user_id, @mess_id, @role_id, @joined_at, NULL);", conn, tx))
            {
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@mess_id", messId);
                cmd.Parameters.AddWithValue("@role_id", roleId);
                cmd.Parameters.AddWithValue("@joined_at", joinedAt);
                cmd.ExecuteNonQuery();
            }
        }

        private void submit4addmem_Click(object sender, EventArgs e)
        {
            // If your textbox is named differently, replace txtEmail with that name.
            string email = textBox4addmem.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter member email.", "Missing email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!radioButton4addman.Checked && !radioButton4addman.Checked)
            {
                MessageBox.Show("Select a role: Manager or Member.", "Role required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        int userId = GetUserIdByEmail(conn, tx, email);
                        if (userId == 0)
                        {
                            tx.Rollback();
                            MessageBox.Show("No user found for this email. Ask them to create an account first.",
                                "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int roleIdManager = GetRoleId(conn, tx, "Manager");
                        int roleIdMember = GetRoleId(conn, tx, "Member");
                        if (roleIdManager == 0 || roleIdMember == 0)
                        {
                            tx.Rollback();
                            MessageBox.Show("Role table is missing required roles (Manager/Member).",
                                "Config error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (HasActiveMembership(conn, tx, userId, CurrentMessId))
                        {
                            tx.Rollback();
                            MessageBox.Show("This user is already a member of the mess.",
                                "Duplicate membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        bool wantManager = radioButton4addman.Checked;

                        if (wantManager)
                        {
                            if (MessAlreadyHasManager(conn, tx, CurrentMessId, roleIdManager))
                            {
                                tx.Rollback();
                                MessageBox.Show("Only one manager can be there for a mess.",
                                    "Manager exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            InsertMembership(conn, tx, userId, CurrentMessId, roleIdManager, DateTime.Today);
                            tx.Commit();
                            MessageBox.Show("Manager added to the mess.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            InsertMembership(conn, tx, userId, CurrentMessId, roleIdMember, DateTime.Today);
                            tx.Commit();
                            MessageBox.Show("Member added to the mess.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox4createadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void email4createadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4createadd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4createaddmem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private static int EnsureRole(SqlConnection conn, SqlTransaction tx, string roleName)
        {
            using (var cmd = new SqlCommand(
                @"IF NOT EXISTS (SELECT 1 FROM dbo.Role WHERE role_name=@n)
                      INSERT INTO dbo.Role(role_name) VALUES(@n);
                  SELECT role_id FROM dbo.Role WHERE role_name=@n;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@n", roleName);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private static int UpsertUserByEmail(SqlConnection conn, SqlTransaction tx, string fullName, string email, string defaultPassword)
        {
            // If user exists, return id and refresh name
            using (var get = new SqlCommand(
                @"SELECT user_id FROM dbo.[User] WHERE LOWER(email)=LOWER(@e);", conn, tx))
            {
                get.Parameters.AddWithValue("@e", email);
                object o = get.ExecuteScalar();
                if (o != null && o != DBNull.Value)
                {
                    int userId = Convert.ToInt32(o);
                    using (var upd = new SqlCommand(
                        @"UPDATE dbo.[User] SET name=@n WHERE user_id=@id;", conn, tx))
                    {
                        upd.Parameters.AddWithValue("@n", fullName);
                        upd.Parameters.AddWithValue("@id", userId);
                        upd.ExecuteNonQuery();
                    }
                    return userId;
                }
            }

            // Otherwise create with default password 123456 (hashed)
            string hash = HashPassword(defaultPassword);
            using (var ins = new SqlCommand(
                @"INSERT INTO dbo.[User](name, email, password_hash)
                  VALUES(@n, @e, @p);
                  SELECT SCOPE_IDENTITY();", conn, tx))
            {
                ins.Parameters.AddWithValue("@n", fullName);
                ins.Parameters.AddWithValue("@e", email);
                ins.Parameters.AddWithValue("@p", hash);
                return Convert.ToInt32(ins.ExecuteScalar());
            }
        }

        private static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(bytes.Length * 2);
                foreach (var b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private static bool HasActiveMembership1(SqlConnection conn, SqlTransaction tx, int userId, int messId)
        {
            using (var cmd = new SqlCommand(
                @"SELECT COUNT(*) FROM dbo.Membership
                  WHERE user_id=@u AND mess_id=@m AND left_at IS NULL;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@m", messId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static bool MessAlreadyHasManager1(SqlConnection conn, SqlTransaction tx, int messId, int roleIdManager)
        {
            // Locks rows so two clicks can't create two managers
            using (var cmd = new SqlCommand(
                @"SELECT COUNT(*) FROM dbo.Membership WITH (UPDLOCK, HOLDLOCK)
                  WHERE mess_id=@m AND role_id=@r AND left_at IS NULL;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@m", messId);
                cmd.Parameters.AddWithValue("@r", roleIdManager);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static void InsertMembership1(SqlConnection conn, SqlTransaction tx,
                                             int userId, int messId, int roleId, DateTime joinedAt)
        {
            using (var cmd = new SqlCommand(
                @"INSERT INTO dbo.Membership(user_id, mess_id, role_id, joined_at, left_at)
                  VALUES(@u, @m, @r, @d, NULL);", conn, tx))
            {
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@m", messId);
                cmd.Parameters.AddWithValue("@r", roleId);
                cmd.Parameters.AddWithValue("@d", joinedAt);
                cmd.ExecuteNonQuery();
            }
        }

        private void submit4createadd_Click(object sender, EventArgs e)
        {
            // If your textbox/radio names differ, rename them here
            string fullName = textBox4createadd.Text.Trim();
            string email = email4createadd.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Enter member full name.", "Missing name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Enter member email address.", "Missing email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!radioButton4createadd.Checked && !radioButton4createaddmem.Checked)
            {
                MessageBox.Show("Select a role: Manager or Member.", "Role required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        // Ensure roles exist
                        int roleIdManager = EnsureRole(conn, tx, "Manager");
                        int roleIdMember = EnsureRole(conn, tx, "Member");

                        // Create or fetch the user by email (default password 123456 if new)
                        int userId = UpsertUserByEmail(conn, tx, fullName, email, defaultPassword: "123456");

                        // Stop duplicate active membership
                        if (HasActiveMembership(conn, tx, userId, CurrentMessId))
                        {
                            tx.Rollback();
                            MessageBox.Show("This user is already an active member of this mess.",
                                "Duplicate membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        bool wantManager = radioButton4createadd.Checked;

                        if (wantManager)
                        {
                            if (MessAlreadyHasManager(conn, tx, CurrentMessId, roleIdManager))
                            {
                                tx.Rollback();
                                MessageBox.Show("Only one manager can be there for a mess.",
                                    "Manager exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            InsertMembership(conn, tx, userId, CurrentMessId, roleIdManager, DateTime.Today);
                            tx.Commit();
                            MessageBox.Show("Manager created and added to the mess.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            InsertMembership(conn, tx, userId, CurrentMessId, roleIdMember, DateTime.Today);
                            tx.Commit();
                            MessageBox.Show("Member created and added to the mess.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

