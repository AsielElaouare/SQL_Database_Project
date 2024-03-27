using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SomerenDAL;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        private List<Drink> selectedDrinksList;
        private Drink selectedDrink;
        private Student selectedStudent;
        private int selectedQuantityDrinks;
        private decimal price;

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
            pnlOrderADrink.Hide();
            pnlQuantityDrinks.Hide();
            pnlRevenue.Hide();
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

        private void DisplayStudentsForOrders(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudentOrder.Items.Clear();

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
                listViewStudentOrder.Items.Add(li);
            }
        }


        private void DisplayDrinksForOrders(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinkOrder.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Id.ToString());
                li.SubItems.Add(drink.Name);
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.Vat.ToString());
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
                ListViewItem li = new ListViewItem(student.studentNumber.ToString());
                li.SubItems.Add(student.firstName);
                li.SubItems.Add(student.lastName);
                li.SubItems.Add(student.phoneNumber.ToString());
                li.SubItems.Add(student.studentClass);
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


        // ORDER VIEW FOR THE ORDER PANEL


        private void UpdateOrderLabel(Drink drink)
        {

            orderViewItems.Text += $"Drink: {drink.Name}; Price: \u20AC{drink.Price}; Quantity: {drink.SelectedQuantity}";


        }

        private void UpdateTotalPrice(Drink drink)
        {

            price = price + drink.Price * drink.SelectedQuantity;
            totalPriceLabel.Text = $"Total: \u20AC{price}";

        }


        private void listViewDrinkOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewDrinkOrder.SelectedItems.Count == 1)
            {

                selectedDrinksList = new List<Drink>();
                ListViewItem selectedItem = listViewDrinkOrder.SelectedItems[0];
                selectedDrink = (Drink)selectedItem.Tag;

                ShowPnlQuantityDrinks();
            }


        }


        private void ShowPnlQuantityDrinks()
        {
            if (selectedDrink.Stock > 0)
            {
                listViewDrinkOrder.Enabled = false;
                pnlQuantityDrinks.Show();
            }
            else
            {
                MessageBox.Show("This Drink is Out of Stock", "Out Of Stock!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HidePnlQuantityDrinks()
        {
            listViewDrinkOrder.Enabled = true;
            pnlQuantityDrinks.Hide();
        }

        //submit quantity 
        private void submitQuantityButton_Click(object sender, EventArgs e)
        {
            selectedQuantityDrinks = int.Parse(textBoxQuantityDrinks.Text);
            selectedDrink.SelectedQuantity = selectedQuantityDrinks;
            if (selectedQuantityDrinks <= selectedDrink.Stock)
            {
                pnlQuantityDrinks.Hide();

                UpdateOrderLabel(selectedDrink);
                UpdateTotalPrice(selectedDrink);
            }
            else
            {
                MessageBox.Show("Selected quantity is higher than drink's stock", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //cancel quantity 
        private void cancelQuantityButton_Click(object sender, EventArgs e)
        {
            HidePnlQuantityDrinks();

        }


        /// submit order button 
        private void submitOrderButtton_Click(object sender, EventArgs e)
        {

            if (selectedStudent != null && selectedDrink != null)
            {
                DrinkDao drinkDao = new DrinkDao();
                Drink drink = selectedDrink;
                drink.Stock = drink.Stock - selectedQuantityDrinks;


                //update database
                CreateOrder();
                drinkDao.UpdateDrink(drink);

                MessageBox.Show("Order Submitted Succesfully");

                //refreshing with updated data after submitting order
                ShowOrderADrinkPanel();
                ResetPanelOptions();
            }
            else
            {
                MessageBox.Show("An error occurred: You need To select a Student AND a Drink", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateOrder()
        {
            Order order = new Order();
            DrinkDao drinkDao = new DrinkDao();
            OrderService orderService = new OrderService();
            DateTime dateNow = DateTime.Now;
            order.StudentId = selectedStudent.studentId;
            order.DrinkId = selectedDrink.Id;
            order.Quantity = selectedQuantityDrinks;
            order.OrderDate = dateNow;
            orderService.AddOrder(order);

        }

        private void listViewStudentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudentOrder.SelectedItems.Count == 1)
            {
                ListViewItem selectedStudentListView = listViewStudentOrder.SelectedItems[0];
                selectedStudent = (Student)selectedStudentListView.Tag;

            }
        }


        // reset changes after order is submitted

        private void ResetPanelOptions()
        {
            listViewDrinkOrder.Enabled = true;
            totalPriceLabel.Text = "Total: ";
            orderViewItems.Text = "";
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
    }
}