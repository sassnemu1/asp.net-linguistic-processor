﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LingusticInterface
{
	public partial class Register : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void buttonRegistr_Click(object sender, EventArgs e)
		{
			string password = inputPasswordRegistr.Value;
			string password_repeat = inputRepeatPasswordRegistr.Value;

			CheckFormRegistration cheackFormOnError = new CheckFormRegistration();
			cheackFormOnError.toCheckFormRegistrationOnError
			(
				inputEmailRegister.Value, 
				inputLoginRegister.Value, 
				password, password_repeat, 
				messageErrorRegister
			);
		}
	}
}

class CheckFormRegistration
{
	public void toCheckFormRegistrationOnError(string email, string login, string password, string password_repeat, TextBox messageErrorRegister) 
	{
		if (password != password_repeat)
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Пароль не совпал";
		}
		else
			messageErrorRegister.Visible = false;

		if (password == "" || password_repeat == "")
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Не введен пароль";
		}
		else
			messageErrorRegister.Visible = false;


		if (email == "")
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Не введен email";
		}
		else
			messageErrorRegister.Visible = false;


		if (login == "")
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Не введен логин";
		}
		else
			messageErrorRegister.Visible = false;
	}
}