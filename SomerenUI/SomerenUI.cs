using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SomerenDAL;
using System.Globalization;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        CultureInfo ci = new CultureInfo("nl-NL");

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void HideAllPanel()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlOrderADrink.Hide();
            pnlRevenue.Hide();
            pnlVatReport.Hide();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            HideAllPanel();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            HideAllPanel();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowLecturersPanel()
        {
            // hide all other panels
            HideAllPanel();

            // show lecturers
            pnlLecturers.Show();

            try
            {
                // get and display all students
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }

        private void ShowActivitiesPanel()
        {
            HideAllPanel();

            pnlActivities.Show();

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + ex.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            // hide all other panels
            HideAllPanel();

            // show rooms
            pnlRooms.Show();

            try
            {
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + ex.Message);
            }
        }


        private void ShowOrderADrinkPanel()
        {
            HideAllPanel();

            pnlOrderADrink.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                List<Drink> drinks = GetDrinks();
                DisplayStudentsForOrders(students);
                DisplayDrinksForOrders(drinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + ex.Message);
            }
        }
        private void ShowRevenuePanel()
        {
            HideAllPanel();

            // show revenue panel
            pnlRevenue.Show();

            DateTime endDate = DateTime.Today;
            DateTime startDate = endDate.AddDays(-7);

            startdatePicker.MaxDate = endDate;
            enddatePicker.MaxDate = endDate;

            startdatePicker.Value = startDate;
            enddatePicker.Value = endDate;
        }
        private void enddatePicker_ValueChanged(object sender, EventArgs e)
        {
            startdatePicker.MaxDate = enddatePicker.Value;
        }

        private void ShowVatReportPanel()
        {
            HideAllPanel();

            pnlVatReport.Show();

            try
            {
                VatReportService VatReportService = new VatReportService();
                List<int> years = VatReportService.GetAvailableYears();

                cbSelectYear.Items.Clear();

                foreach (int year in years)
                {
                    cbSelectYear.Items.Add(year);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + ex.Message);
            }
        }



        private void DisplayStudentsForOrders(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudentOrder.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.firstName);
                li.SubItems.Add(student.lastName);
                //li.SubItems.Add(student.roomId.ToString());
                li.Tag = student;   // link student object to listview item
                listViewStudentOrder.Items.Add(li);
            }
        }


        private void DisplayDrinksForOrders(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinkOrder.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.isAlcoholic.ToString());
                li.SubItems.Add(drink.Stock.ToString());
                //li.SubItems.Add(student.roomId.ToString());
                li.Tag = drink;   // link student object to listview item
                listViewDrinkOrder.Items.Add(li);
            }
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.studentId.ToString());
                li.SubItems.Add(student.studentNumber.ToString());
                li.SubItems.Add(student.firstName);
                li.SubItems.Add(student.lastName);
                li.SubItems.Add(student.studentClass);
                li.SubItems.Add(student.phoneNumber.ToString());
                //li.SubItems.Add(student.roomId.ToString());
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            listViewLecturers.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.TeacherId.ToString());
                li.SubItems.Add(teacher.FirstName);
                li.SubItems.Add(teacher.LastName);
                li.SubItems.Add(teacher.Age.ToString());
                li.SubItems.Add(teacher.PhoneNumber);
                li.Tag = teacher;

                listViewLecturers.Items.Add(li);
            }

        }

        private void DisplayActivities(List<Activity> activities)
        {
            listViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.Id.ToString());
                li.SubItems.Add(activity.Name);
                li.SubItems.Add(activity.Day);
                li.SubItems.Add(activity.StartTime.ToString());
                li.SubItems.Add(activity.EndTime.ToString());
                li.Tag = activity;
                listViewActivities.Items.Add(li);

            }
        }

        private void DisplayRooms(List<Room> rooms)
        {
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.roomId.ToString());
                li.SubItems.Add(room.roomName);
                li.SubItems.Add(room.roomType);
                li.SubItems.Add(room.size.ToString());
                li.Tag = room;
                listViewRooms.Items.Add(li);

            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Drink> GetDrinks()
        {
            DrinksService drinkService = new DrinksService();
            List<Drink> drinks = drinkService.GetDrink();
            return drinks;
        }

        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            HideAllPanel();
            pnlDashboard.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void orderADrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderADrinkPanel();

        }

        private void vatReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVatReportPanel();
        }

        private void submitOrderButtton_Click(object sender, EventArgs e)
        {
            if (listViewDrinkOrder.SelectedItems.Count == 0 || listViewStudentOrder.SelectedItems.Count == 0) return;

            Drink selectedDrink = new Drink();
            Student selectedStudent = new Student();

            ListViewItem selectedDrinkItem = listViewDrinkOrder.SelectedItems[0];
            selectedDrink = (Drink)selectedDrinkItem.Tag;

            ListViewItem selectedStudentItem = listViewStudentOrder.SelectedItems[0];
            selectedStudent = (Student)selectedStudentItem.Tag;

            int quantity = (int)textBoxQuantityDrinks.Value;

            if (quantity > 0)
            {
                ResetLabels();
                MessageBox.Show("Order Submitted Succesfully", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CreateOrder(selectedDrink, selectedStudent, quantity);
                List<Drink> drinks = GetDrinks();
                DisplayDrinksForOrders(drinks);
            }
            else
            {
                MessageBox.Show("Drink is out of Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateOrderLabel(Drink drink)
        {
            orderViewItems.Text = $"Drink: {drink.Name} Price: {drink.Price} Alcohol: {drink.isAlcoholic}, Quantity: {textBoxQuantityDrinks.Value}";
        }

        private void CreateOrder(Drink selectedDrink, Student selectedStudent, int quantity)
        {
            OrderService orderService = new OrderService();
            Order order = new Order();
            DrinkDao drinkDao = new DrinkDao();
            Drink drink = selectedDrink;
            drink.Stock = drink.Stock - quantity;
            drinkDao.UpdateDrink(drink);
            DateTime dateNow = DateTime.Now;
            order.StudentId = selectedStudent.studentId;
            order.DrinkId = selectedDrink.Id;
            order.Quantity = quantity;
            order.OrderDate = dateNow;
            orderService.AddOrder(order);
        }

        private void textBoxQuantityDrinks_ValueChanged(object sender, EventArgs e)
        {
            Drink drink = (Drink)listViewDrinkOrder.SelectedItems[0].Tag;
            totalPriceLabel.Text = $"Total: \u20AC{drink.Price * textBoxQuantityDrinks.Value}";
            UpdateOrderLabel(drink);
        }

        private void ResetLabels()
        {
            orderViewItems.Text = "";
            totalPriceLabel.Text = "Total: ";
        }

        private void listViewDrinkOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinkOrder.SelectedItems.Count != 0)
            {
                Drink drink = (Drink)listViewDrinkOrder.SelectedItems[0].Tag;
                textBoxQuantityDrinks.Minimum = 1;
                textBoxQuantityDrinks.Maximum = drink.Stock;
                UpdateOrderLabel(drink);
            }
        }

        private void reportGeneratorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Optionally, you can display the revenue data for the default date range
                RevenueService revenueService = new RevenueService();
                RevenueDao dao = new RevenueDao();
                Revenue revenue = revenueService.GetRevenue(startdatePicker.Value, enddatePicker.Value);

                // Display revenue data
                outputSales.Text = $"{revenue.Sales} ";
                outputTurnover.Text = $"{revenue.Turnover} ";
                outputNoC.Text = $"{revenue.NumberOfCustomers} ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the revenue: " + ex.Message);
            }
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void cbSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateQuarterlyVatReport();
        }

        private void cbSelectQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateQuarterlyVatReport();
        }

        private void generateQuarterlyVatReport()
        {
            if (cbSelectYear.SelectedIndex == -1 || cbSelectQuarter.SelectedIndex == -1) return;

            QuarterDates quarterDates = CalculateQuarterDates(int.Parse(cbSelectYear.Text), cbSelectQuarter.SelectedIndex + 1);

            lblDateFrom.Text = quarterDates.StartQuarterDate.ToString("dd-MM-yyyy");
            lblDateTo.Text = quarterDates.EndQuarterDate.ToString("dd-MM-yyyy");

            try
            {
                VatReportService vatReportService = new VatReportService();

                VatReport vatReport = vatReportService.GetVatReport(quarterDates.StartQuarterDate, quarterDates.EndQuarterDate);

                lblVatLow.Text = vatReport.VatLow.ToString("C", ci);
                lblVatHigh.Text = vatReport.VatHigh.ToString("C", ci);
                lblVatTotal.Text = vatReport.VatTotal.ToString("C", ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + ex.Message);
            }
        }

        public class QuarterDates
        {
            public DateOnly StartQuarterDate { get; set; }
            public DateOnly EndQuarterDate { get; set; }
        }

        private QuarterDates CalculateQuarterDates(int year, int quarter)
        {
            var startQuarterMonth = (quarter - 1) * 3 + 1;
            var endQuarterMonth = startQuarterMonth + 2;
            var daysInMonth = DateTime.DaysInMonth(year, endQuarterMonth);
            var startQuarterDate = new DateOnly(year, startQuarterMonth, 1);
            var endQuarterDate = new DateOnly(year, endQuarterMonth, daysInMonth);

            return new QuarterDates
            {
                StartQuarterDate = startQuarterDate,
                EndQuarterDate = endQuarterDate
            };
        }

        private void ShowDrinksPanel()
        {
            HideAllPanel();
            pnlDrinks.Show();
            LoadDrinks();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void LoadDrinks()
        {
            try
            {
                listViewDrinks.Items.Clear();

                DrinksService drinksService = new DrinksService();
                List<Drink> drinks = drinksService.GetAllDrinks();

                foreach (Drink drink in drinks)
                {
                    ListViewItem item = new ListViewItem(drink.Id.ToString());
                    item.SubItems.Add(drink.Name.ToString());
                    item.SubItems.Add(drink.isAlcoholic.ToString());
                    item.SubItems.Add(drink.Price.ToString());
                    item.SubItems.Add(drink.Stock.ToString());

                    if (drink.Stock < 10)
                    {
                        item.SubItems.Add("Stock nearly depleted");
                    }
                    else
                    {
                        item.SubItems.Add("Stock sufficient");
                    }

                    item.Tag = drink;

                    listViewDrinks.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drinks: {ex.Message}");
            }
        }

        private void AddDrinks()
        {
            try
            {
                Drink drinks = new Drink();
                DrinksService drinksService = new DrinksService();
                drinks.Name = drinkNameTextBox.Text;
                if (!bool.TryParse(drinkAlcoholischTextBox.Text, out bool isAlcoholic))
                {
                    MessageBox.Show("Invalid input for alcoholic. Please enter 'true' or 'false'.");
                    return;
                }
                drinks.isAlcoholic = isAlcoholic;
                drinks.Price = decimal.Parse(drinkPriceTextBox.Text);
                drinks.Stock = int.Parse(drinkStockTextBox.Text);
                drinksService.AddDrink(drinks);
                MessageBox.Show($"Succesfully added: {drinks.Name}");
                LoadDrinks();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot add this drink{ex.Message}");
            }
        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            AddDrinks();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrinks.SelectedItems[0];

                Drink selectedDrink = (Drink)selectedItem.Tag;

                try
                {
                    DrinksService drinksService = new DrinksService();

                    drinksService.DeleteDrink(selectedDrink);
                    LoadDrinks();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting drink: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a drink to delete.");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrinks.SelectedItems[0];

                Drink selectedDrink = (Drink)selectedItem.Tag;

                selectedDrink.Name = drinkNameTextBox.Text;
                if (!bool.TryParse(drinkAlcoholischTextBox.Text, out bool isAlcoholic))
                {
                    MessageBox.Show("Invalid input for alcoholic. Please enter 'true' or 'false'.");
                    return;
                }
                selectedDrink.isAlcoholic = isAlcoholic;
                selectedDrink.Price = decimal.Parse(drinkPriceTextBox.Text);
                selectedDrink.Stock = int.Parse(drinkStockTextBox.Text);

                try
                {

                    DrinksService drinksService = new DrinksService();


                    drinksService.UpdateDrink(selectedDrink);


                    LoadDrinks();

                    MessageBox.Show("Drink details updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating drink details: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a drink to modify.");
            }
        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listViewDrinks.SelectedItems[0];


                Drink selectedDrink = (Drink)selectedItem.Tag;

                drinkNameTextBox.Text = selectedDrink.Name;
                drinkAlcoholischTextBox.Text = selectedDrink.isAlcoholic.ToString();
                drinkPriceTextBox.Text = selectedDrink.Price.ToString();
                drinkStockTextBox.Text = selectedDrink.Stock.ToString();
            }
        }
    }
}