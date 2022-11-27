﻿using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
	public class HomeController : Controller
	{
		[Route("home")]
		[Route("/")]
		public IActionResult Index()
		{
			ViewData["appTitle"] = "Asp.Net Core Demo App";

			List<Person> people = new List<Person>()
			{
				new Person()
				{
					Name = "John",
					DateOfBirth = DateTime.Parse("2000-05-06"),
					PersonGender = Gender.Male
				},
				new Person()
				{
					Name = "Linda",
					DateOfBirth = DateTime.Parse("2006-01-09"),
					PersonGender = Gender.Female
				},
				new Person()
				{
					Name = "Susan",
					DateOfBirth = null,
					PersonGender = Gender.Other
				},
			};

			// Views/Home/Index.cshtml
			return View("Index", people);
		}


		[Route("person-details/{name}")]
		public IActionResult Details(string? name)
		{
			if (name == null)
				return Content("Person name can't be null");

			List<Person> people = new List<Person>()
			{
				new Person()
				{
					Name = "John",
					DateOfBirth = DateTime.Parse("2000-05-06"),
					PersonGender = Gender.Male
				},
				new Person()
				{
					Name = "Linda",
					DateOfBirth = DateTime.Parse("2006-01-09"),
					PersonGender = Gender.Female
				},
				new Person()
				{
					Name = "Susan",
					DateOfBirth = null,
					PersonGender = Gender.Other
				},
			};

			Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();

			// Views/Home/Details.cshtml
			return View(matchingPerson);
		}

		[Route("person-with-product")]
		public IActionResult PersonWithProduct()
		{
			Person person = new Person()
			{
				Name = "Sara",
				PersonGender = Gender.Female,
				DateOfBirth = Convert.ToDateTime("2004-07-01")
			};

			Product product = new Product()
			{
				ProductId = 1,
				ProductName = "Air Conditioner"
			};

			PersonAndProductWrapperModel personAndProductWrapperModel = new PersonAndProductWrapperModel()
			{
				PersonData = person,
				ProductData = product
			};

			return View(personAndProductWrapperModel);
		}

		[Route("home/all-products")]
		public IActionResult All()
		{
			// Views/Products/All.cshtml
			// Views/Shared/All.cshtml
			return View();
		}

	}
}
