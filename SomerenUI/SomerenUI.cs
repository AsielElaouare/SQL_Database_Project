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
				Drink drink = new Drink();
				drink = selectedDrink;
				drink.Stock = drink.Stock - selectedQuantityDrinks;
				OrderService orderService = new OrderService();
				Order order = new Order();
				order.StudentId = selectedStudent.studentId;
				order.DrinkId = selectedDrink.Id;
				order.Quantity = selectedQuantityDrinks;
				drinkDao.UpdateDrink(drink);
				orderService.AddOrder(order);
				ResetPanelOptions();
				MessageBox.Show("Order Submitted Succesfully");

				//refreshing with updated data after submitting order
				ShowOrderADrinkPanel();
			}
			else
			{
				MessageBox.Show("An error occurred: You need To select a Student AND a Drink", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
	}
}