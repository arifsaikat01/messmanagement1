using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace messmanagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BuildMiddleUsingDesignerContainers();   // only touches panel2 + its children
        }

        private void BuildMiddleUsingDesignerContainers()
        {
            // ---------- METRICS ROW (flowLayoutPanel1) ----------
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Height = 120;
            flowLayoutPanel1.BackColor = Color.Transparent;

            flowLayoutPanel1.Controls.Add(CreateMetricCard("My Total Meal", "0.00", ColorTranslator.FromHtml("#E6F3FF")));
            flowLayoutPanel1.Controls.Add(CreateMetricCard("My Deposit", "0.00 ৳", ColorTranslator.FromHtml("#D7F3EC")));
            flowLayoutPanel1.Controls.Add(CreateMetricCard("My Cost", "0.00 ৳", ColorTranslator.FromHtml("#FAD6D6")));
            flowLayoutPanel1.Controls.Add(CreateMetricCard("My Balance", "0.00 ৳", ColorTranslator.FromHtml("#FFF1B6")));
            flowLayoutPanel1.ResumeLayout();

            // ---------- 2-COLUMN BODY (tableLayoutPanel1) ----------
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 260));

            // Left: month summary
            var monthCard = CreateCard(Color.White, true, 16);
            monthCard.Margin = new Padding(0, 0, 12, 12);
            monthCard.Size = new Size(520, 260);
            var title = MakeLabel("our mess, September (Running)", 12, FontStyle.Bold, Color.FromArgb(34, 34, 34));
            title.Dock = DockStyle.Top;
            title.Padding = new Padding(12, 10, 12, 8);
            monthCard.Controls.Add(title);

            var info = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                ColumnCount = 2,
                Padding = new Padding(18, 0, 18, 12)
            };
            info.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24));
            info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            AddLine(info, "Mess Balance: 0.00 ৳");
            AddLine(info, "Total Deposit: 0.00 ৳");
            AddLine(info, "Total Meal: 0.00");
            AddLine(info, "Total Meal Cost: 0.00 ৳");
            AddLine(info, "Meal Rate: ____ ৳");
            AddLine(info, "Total Individual Other Cost: 0.00 ৳");
            AddLine(info, "Total Shared Other Cost: 0.00 ৳");
            AddLine(info, "This Month Full Details:");
            monthCard.Controls.Add(info);

            // Right: bazar block only (no “free membership”)
            var rightCol = new Panel { Dock = DockStyle.Fill };
            var bazar = CreateCard(Color.White, true, 16);
            bazar.Dock = DockStyle.Top;
            bazar.Height = 76;
            bazar.Margin = new Padding(0, 8, 0, 0);
            var bzTitle = MakeLabel("My Bazar Date", 11, FontStyle.Bold, Color.FromArgb(34, 34, 34));
            bzTitle.Location = new Point(12, 10);
            bazar.Controls.Add(bzTitle);
            var bzBtn = new Button
            {
                Text = "বাজার ডেইট সেট করুন",
                Font = new Font("Segoe UI", 9F),
                Height = 32,
                Width = 170,
                Location = new Point(12, 38),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(240, 242, 247)
            };
            bzBtn.FlatAppearance.BorderSize = 0;
            bazar.Controls.Add(bzBtn);
            rightCol.Controls.Add(bazar);

            tableLayoutPanel1.Controls.Add(monthCard, 0, 0);
            tableLayoutPanel1.Controls.Add(rightCol, 1, 0);
            tableLayoutPanel1.ResumeLayout();

            // ---------- MEMBER HEADER + LIST (label1 + flowLayoutPanel2) ----------
            // Center the header without editing the Designer file
            label1.AutoSize = false;
            label1.Dock = DockStyle.Top;
            label1.Height = 28;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "All Member Info";

            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.WrapContents = true;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Padding = new Padding(8);

            // Member cards with two-column detail (this is what you said was missing)
            flowLayoutPanel2.Controls.Add(CreateMemberCardTwoCol(
                "Asir",
                new[] { "Total Meal: 0.00", "Meal Cost: 0.00 ৳", "Individual Cost: 0.00 ৳", "Balance: 0.00 ৳" },
                new[] { "Total Deposit: 0.00 ৳", "Shared Cost: 0.00 ৳", "Total Cost: 0.00 ৳" }
            ));
            flowLayoutPanel2.Controls.Add(CreateMemberCardTwoCol(
                "Arif Saikat",
                new[] { "Total Meal: 0.00", "Meal Cost: 0.00 ৳", "Individual Cost: 0.00 ৳", "Balance: 0.00 ৳" },
                new[] { "Total Deposit: 0.00 ৳", "Shared Cost: 0.00 ৳", "Total Cost: 0.00 ৳" }
            ));
            flowLayoutPanel2.ResumeLayout();
        }

        // ---------- helpers ----------
        private static Label MakeLabel(string text, float size, FontStyle style, Color color) =>
            new Label { AutoSize = true, Text = text, Font = new Font("Segoe UI", size, style), ForeColor = color };

        private void AddLine(TableLayoutPanel host, string text)
        {
            var dot = new Label { Text = "•", AutoSize = true, ForeColor = Color.FromArgb(102, 102, 102), Margin = new Padding(0, 4, 6, 4) };
            var txt = MakeLabel(text, 9.5f, FontStyle.Regular, Color.FromArgb(34, 34, 34)); txt.Margin = new Padding(0, 4, 0, 4);
            host.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            host.Controls.Add(dot, 0, host.RowCount);
            host.Controls.Add(txt, 1, host.RowCount);
            host.RowCount += 1;
        }

        private Panel CreateMetricCard(string title, string value, Color fill)
        {
            var card = CreateCard(fill, false, 16);
            card.Size = new Size(220, 110);
            card.Margin = new Padding(8, 0, 8, 0);
            var v = MakeLabel(value, 18, FontStyle.Bold, Color.FromArgb(34, 34, 34)); v.Location = new Point(14, 12);
            var t = MakeLabel(title, 9, FontStyle.Regular, Color.FromArgb(90, 90, 90)); t.Location = new Point(14, 70);
            card.Controls.Add(v); card.Controls.Add(t);
            return card;
        }

        private Panel CreateMemberCardTwoCol(string name, string[] leftCol, string[] rightCol)
        {
            var card = CreateCard(Color.White, true, 16);
            card.Size = new Size(460, 150);
            card.Margin = new Padding(0, 0, 12, 12);

            var title = MakeLabel(name, 11, FontStyle.Bold, Color.FromArgb(34, 34, 34));
            title.Location = new Point(12, 10);
            card.Controls.Add(title);

            var grid = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = Math.Max(leftCol.Length, rightCol.Length),
                Location = new Point(12, 36),
                Size = new Size(card.Width - 24, card.Height - 48),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            for (int i = 0; i < grid.RowCount; i++) grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < leftCol.Length; i++) grid.Controls.Add(MakeLabel(leftCol[i], 9.5f, FontStyle.Regular, Color.FromArgb(34, 34, 34)), 0, i);
            for (int i = 0; i < rightCol.Length; i++) grid.Controls.Add(MakeLabel(rightCol[i], 9.5f, FontStyle.Regular, Color.FromArgb(34, 34, 34)), 1, i);

            card.Controls.Add(grid);
            return card;
        }

        // Rounded panel used for all “cards”
        private RoundCard CreateCard(Color fill, bool withBorder, int radius) =>
            new RoundCard
            {
                FillColor = fill,
                BorderColor = withBorder ? Color.FromArgb(230, 233, 239) : Color.Transparent,
                BorderThickness = withBorder ? 1 : 0,
                Radius = radius,
                Padding = new Padding(8),
                BackColor = Color.Transparent
            };

        // ===== Top menu click stubs (to satisfy Designer wiring) =====
        private void button5_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

    }

    // simple rounded panel control
    public class RoundCard : Panel
    {
        public int Radius { get; set; } = 14;
        public Color FillColor { get; set; } = Color.White;
        public Color BorderColor { get; set; } = Color.FromArgb(230, 233, 239);
        public int BorderThickness { get; set; } = 1;

        public RoundCard() { DoubleBuffered = true; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = Rounded(rect, Radius))
            using (var fill = new SolidBrush(FillColor))
            using (var pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.FillPath(fill, path);
                if (BorderThickness > 0) e.Graphics.DrawPath(pen, path);
            }
        }
        protected override void OnResize(EventArgs e) { base.OnResize(e); Invalidate(); }

        private static GraphicsPath Rounded(Rectangle r, int radius)
        {
            int d = radius * 2;
            var gp = new GraphicsPath();
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }
    }

}

