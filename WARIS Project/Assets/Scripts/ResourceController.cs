using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class ResourceController : MonoBehaviour 
{
	private BuildingManager bm = new BuildingManager();
	private StaffManager sm = new StaffManager();
	private LectureManager lm = new LectureManager();
	public TextAsset txtfile;

	void Awake()
	{
		LoadAllData (); //load all data when application runs
	}

	public BuildingManager GetBuildingManager()
	{
		return bm;
	}

	public StaffManager GetStaffManager()
	{
		return sm;
	}

	public LectureManager GetLectureManager()
	{
		return lm;
	}

	/// <summary>
	/// Loads all data.
	/// </summary>
	void LoadAllData()
	{
		LoadLectureData (); //load lecture data, MUST happen BEFORE loading building data
		LoadStaffData (); //load staff data
		LoadBuildingData (); //load building data
	}

	/// <summary>
	/// Loads the building data.
	/// </summary>
	void LoadBuildingData()
	{
		Building temp;

		//load science and computing data
		temp = new Building ("245", "Science and Computing");
		//add occupant names
		temp.AddOccupant ("Shri Rai");
		temp.AddOccupant ("Dr Mohd Fairuz Shiratuddin");
		temp.AddOccupant ("Danny Toohey");
		temp.AddOccupant ("Dr Kevin Wong");
		temp.AddOccupant ("Dr Hong Xie");
		temp.AddOccupant ("Dr Nik Thompson");
		temp.AddOccupant ("Dr Pyara Dhillon");
		temp.AddOccupant ("Dr Christian Payne");
		temp.AddOccupant ("Peter Cole");
		temp.AddOccupant ("Dr Graham Mann");
		//add services
		temp.AddService ("Computing Labs x5");
		temp.AddService ("Meeting Rooms x3");
		temp.AddService ("Research Labs x18");
		temp.AddService ("Male Toilets lvl 2");
		temp.AddService ("Female Toilets lvl 2");
		temp.AddService ("Male Toilets lvl 3");
		temp.AddService ("Female Toilets lvl 3");
		temp.AddService ("Male Emergency Shower 3.048");
		temp.AddService ("Female Emergency Shower 3.046");
		temp.AddService ("First Aid Room 3.052");
		temp.AddService ("RLT");
		//add lectures
		temp.AddLecture (8);
		//add building to building manager
		bm.AddBuilding (temp);

		//load library
		temp = new Building ("350", "Library");
		//add occupant names
		temp.AddOccupant ("Pamela Martin-Lynch");
		temp.AddOccupant ("Dr Rebecca Bennett");
		temp.AddOccupant ("Karyn Barenberg");
		temp.AddOccupant ("Dr Angela Jones");
		temp.AddOccupant ("Professor Geoffrey Bolton");
		temp.AddOccupant ("Kate Makowiecka");
		temp.AddOccupant ("Sonia Boccardo");
		temp.AddOccupant ("Ghylene Palmer");
		temp.AddOccupant ("Joanne Lisciandro");
		temp.AddOccupant ("Jodie-Lee McLeod");
		//add services
		temp.AddService ("Computing Labs x5");
		temp.AddService ("Meeting Rooms x2");
		temp.AddService ("Private Study Rooms x20");
		temp.AddService ("Silent Computing Lab lvl 1 South");
		temp.AddService ("Library & Information Services lvl 2 South");
		temp.AddService ("After Hours Entry lvl 2 Learning Link");
		temp.AddService ("DVD Viewing Rooms x3");
		temp.AddService ("Photocopying & Printing Services");
		temp.AddService ("IT Service Desk lvl 3 North");
		temp.AddService ("Reserve Section lvl 3 North");
		//no lectures
		//add building to building manager
		bm.AddBuilding (temp);

		//load ECL
		temp = new Building ("460", "Economics, Commerce and Law");
		//add occupant names
		temp.AddOccupant ("Andrew Syme");
		temp.AddOccupant ("Abigayle Carmody");
		temp.AddOccupant ("Nikola Horley");
		temp.AddOccupant ("Supratik Mukherji");
		temp.AddOccupant ("Dr Courtney Field");
		//add services
		temp.AddService ("Male/Female Toilets");
		temp.AddService ("Lift Access");
		temp.AddService ("Kitchens");
		temp.AddService ("Meeting/Seminar Rooms");
		temp.AddService ("Computer Labs");
		temp.AddService ("Post Graduate Area");
		temp.AddService ("Lunch Box Cafe");
		temp.AddService ("First Aid Boxes");
		temp.AddService ("Security Call Points");
		temp.AddService ("Catholic Chaplain");
		temp.AddService ("ECL1");
		temp.AddService ("ECL2");
		temp.AddService ("ECL3");
		temp.AddService ("ECL4");
		//add lectures
		temp.AddLecture (1);
		temp.AddLecture (9);
		temp.AddLecture (16);
		temp.AddLecture (17);
		temp.AddLecture (21);
		//add building to building manager
		bm.AddBuilding (temp);

		//load Chancellery
		temp = new Building ("330", "Chancellery");
		//add occupant names
		temp.AddOccupant ("Linda Barton");
		temp.AddOccupant ("Dr Erich von Dietze");
		temp.AddOccupant ("Dr Graham O'Hara");
		temp.AddOccupant ("Joanne Hulme");
		temp.AddOccupant ("Paul Comiskey");
		//add services
		temp.AddService ("Meeting Rooms x5");
		temp.AddService ("Male Toilets lvl 1");
		temp.AddService ("Female Toilets lvl 1");
		temp.AddService ("Male Toilets lvl 2");
		temp.AddService ("Female Toilets lvl 2");
		//no lectures
		//add building to building manager
		bm.AddBuilding (temp);



//		//Load building data here
//		string dirInfo = Application.dataPath + "/Resources/Buildings";
//		string[] subdirectories = Directory.GetDirectories (dirInfo);
//
//		foreach (string d in subdirectories) //for each directory
//		{
//			Building temp = new Building();
//			DirectoryInfo dir = new DirectoryInfo(d);
//			string path = dir.Name;
//			txtfile = Resources.Load("Buildings/" + path + "/building_info") as TextAsset;
//			char[] separators = {'\n'};
//			string[] linesFromfile = txtfile.text.Split (separators);
//			string[] tokens;
//
//			//occupants
//			int oIndex = 3; //index of first occupant
//			tokens = linesFromfile[oIndex-1].Split(':'); //split "Number of Occupants: " string
//			int oCount = Int32.Parse (tokens[1].Trim()); //get number of occupants
//			//Debug.Log("OCCUPANTS " + oIndex.ToString() + "   " + tokens[1].Trim() + "   " + oCount.ToString());
//
//			//services
//			int sIndex = oIndex + oCount + 1; //index of first service
//			tokens = linesFromfile[sIndex-1].Split(':'); //split "Number of Services: " string
//			int sCount = Int32.Parse (tokens[1].Trim()); //get the number of services
//			//Debug.Log("SERVICES " + sIndex.ToString() + "   " + tokens[1].Trim() + "   " + sCount.ToString());
//
//			//lectures
//			int lIndex = sIndex + sCount + 1; //index of the first lecture
//			tokens = linesFromfile[lIndex-1].Split(':'); //split "Number of Lectures: " string
//			//Debug.Log(tokens[1]);
//			int lCount = Int32.Parse (tokens[1].Trim()); //get the number of lectures
//
//			//set building number
//			tokens = linesFromfile[0].Split(':'); //split the "Building Number: " string
//			temp.SetNumber(tokens[1].Trim()); //set the building number
//
//			//set building name
//			tokens = linesFromfile[1].Split(':'); //split the "Building Name: " string
//			temp.SetName(tokens[1].Trim()); //set the building name
//
//			//add occupants
//			for(int i=oIndex; i<oIndex + oCount; i++)
//			{
//				temp.AddOccupant(linesFromfile[i]);
//			}
//
//			//add services
//			for(int i=sIndex; i<sIndex + sCount; i++)
//			{
//				temp.AddService(linesFromfile[i]);
//			}
//
//			//add lectures
//			if(lCount > 0)
//			{
//				for(int i=lIndex; i<lIndex + lCount; i++) //for each lecture
//				{
//					string room = linesFromfile[i].Trim ();
//					temp.AddService(room + " (Lecture Room)");
//
//					for(int j=0; j<lm.NumberOfLectures(); j++) //for each lecture in lecture manager
//					{
//						//Debug.Log(lm.GetLectureAt(j).GetRoom());
//						if(lm.GetLectureAt(j).GetRoom().Trim().Equals(room)) //if the lecture room matches current lecture room
//							temp.AddLecture(lm.GetLectureAt(j).GetID());
//					}
//				}
//			}
//
//			bm.AddBuilding(temp);
//		}

//		Debug.Log (">>>No Buildings");
//		Debug.Log(bm.NumberOfBuildings().ToString());
//
//		for(int i=0; i<bm.NumberOfBuildings(); i++)
//		{
//			Debug.Log (">>>Building");
//			Debug.Log(bm.GetBuildingAt(i).GetName());
//			Debug.Log(bm.GetBuildingAt(i).GetNumber());
//
//			Debug.Log (">>>Occupants");
//			for(int j=0; j<bm.GetBuildingAt(i).NumberOfOccupants(); j++)
//				Debug.Log(bm.GetBuildingAt(i).GetOccupantAt(j));
//
//			Debug.Log (">>>Services");
//			for(int j=0; j<bm.GetBuildingAt(i).NumberOfServices(); j++)
//				Debug.Log(bm.GetBuildingAt(i).GetServiceAt(j));
//
//			Debug.Log (">>>Lectures");
//			Debug.Log(bm.GetBuildingAt(i).NumberOfLectures());
//			for(int j=0; j<bm.GetBuildingAt(i).NumberOfLectures(); j++)
//			{
//				int id = bm.GetBuildingAt(i).GetLectureAt(j);
//
//				for(int k=0; k<lm.NumberOfLectures(); k++)
//				{
//					if(lm.GetLectureAt(k).GetID() == id)
//						Debug.Log(lm.GetLectureAt(k).GetUnitCode() + " " + lm.GetLectureAt(k).GetUnitName());
//				}
//			}
//		}
	}

	/// <summary>
	/// Loads the staff data.
	/// </summary>
	void LoadStaffData()
	{
		Staff temp;

		//building 245
		//Shri Rai
		temp = new Staff ();
		temp.SetName ("Shri Rai");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.019");
		temp.AddPhone ("9360 6090");
		temp.SetEmail ("s.rai@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Senior Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Nik Thompson
		temp = new Staff ();
		temp.SetName ("Dr Nik Thompson");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.011");
		temp.AddPhone ("9360 1258");
		temp.SetEmail ("N.Thompson@murdoch.edu.au");
		temp.SetPhoto ("759.jpg");
		temp.SetPosition ("Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Fairuz Shiratuddin
		temp = new Staff ();
		temp.SetName ("Dr Mohd Fairuz Shiratuddin");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.014");
		temp.AddPhone ("9360 2794");
		temp.SetEmail ("f.shiratuddin@murdoch.edu.au");
		temp.SetPhoto ("341.jpg");
		temp.SetPosition ("Senior Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Christian Payne
		temp = new Staff ();
		temp.SetName ("Dr Christian Payne");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.015");
		temp.AddPhone ("9360 2778");
		temp.SetEmail ("c.payne@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Lecturer - Information Technology");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Hong Xie
		temp = new Staff ();
		temp.SetName ("Dr Hong Xie");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.016");
		temp.AddPhone ("9360 6087");
		temp.SetEmail ("H.Xie@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Senior Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Kevin Wong
		temp = new Staff ();
		temp.SetName ("Dr Kevin Wong");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.018");
		temp.AddPhone ("9360 6100");
		temp.SetEmail ("K.Wong@murdoch.edu.au");
		temp.SetPhoto ("511.gif");
		temp.SetPosition ("Associate Professor");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Danny Toohey
		temp = new Staff ();
		temp.SetName ("Danny Toohey");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.020");
		temp.AddPhone ("9360 2800");
		temp.SetEmail ("D.Toohey@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Associate Dean for Learning and Teaching");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Peter Cole
		temp = new Staff ();
		temp.SetName ("Peter Cole");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.024");
		temp.AddPhone ("9360 2918");
		temp.SetEmail ("p.cole@murdoch.edu.au");
		temp.SetPhoto ("317.jpg");
		temp.SetPosition ("Senior Lecturer Information Technology");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Pyara Dhillon
		temp = new Staff ();
		temp.SetName ("Dr Pyara Dhillon");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.025");
		temp.AddPhone ("9360 2799");
		temp.SetEmail ("P.Dhillon@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Academic Head of Computer Science");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Graham Mann
		temp = new Staff ();
		temp.SetName ("Dr Graham Mann");
		temp.SetBuildingNo ("245");
		temp.SetOfficeNo("1.013");
		temp.AddPhone ("9360 7270");
		temp.SetEmail ("G.Mann@murdoch.edu.au");
		temp.SetPhoto ("822.jpg");
		temp.SetPosition ("Senior Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Engineering and Information Technology");
		temp.AddOrganisation ("Information Technology");
		//add to staff manager
		sm.AddStaff (temp);

		//building 350
		//Pamela Martin-Lynch
		temp = new Staff ();
		temp.SetName ("Pamela Martin-Lynch");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("4.004");
		temp.AddPhone ("9360 2519");
		temp.SetEmail ("p.martin-lynch@murdoch.edu.au");
		temp.SetPhoto ("772.jpg");
		temp.SetPosition ("Lecturer");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Centre for University Teaching and Learning");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Rebecca Bennett
		temp = new Staff ();
		temp.SetName ("Dr Rebecca Bennett");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("4.005");
		temp.AddPhone ("9360 2355");
		temp.SetEmail ("Rebecca.Bennet@murdoch.edu.au");
		temp.SetPhoto ("549.jpg");
		temp.SetPosition ("Lecturer Academic - Language and Literacy");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Centre for University Teaching and Learning");
		//add to staff manager
		sm.AddStaff (temp);

		//Karyn Barenberg
		temp = new Staff ();
		temp.SetName ("Karyn Barenberg");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("4.007");
		temp.AddPhone ("9360 2142");
		temp.SetEmail ("K.Barenberg@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Administration Assistant");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Centre for University Teaching and Learning");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Angela Jones
		temp = new Staff ();
		temp.SetName ("Dr Angela Jones");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("4.008");
		temp.AddPhone ("9360 6584");
		temp.SetEmail ("A.Jones@murdoch.edu.au");
		temp.SetPhoto ("743.jpg");
		temp.SetPosition ("Administration Assistant");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Centre for University Teaching and Learning");
		//add to staff manager
		sm.AddStaff (temp);

		//Professor Geoffrey Bolton
		temp = new Staff ();
		temp.SetName ("Professor Geoffrey Bolton");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("1.012");
		temp.AddPhone ("9360 6857");
		temp.SetEmail ("G.Bolton@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Emeritus Professor");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Arts");
		//add to staff manager
		sm.AddStaff (temp);

		//Kate Makowiecka
		temp = new Staff ();
		temp.SetName ("Kate Makowiecka");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("3.012");
		temp.AddPhone ("9360 7491");
		temp.SetEmail ("K.Makowiecka@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("University Copyright Coordinator");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Library and Information Services Office");
		temp.AddOrganisation ("Client Services and Information Access");
		temp.AddOrganisation ("Administration and Systems");
		temp.AddOrganisation("Library Administration");
		//add to staff manager
		sm.AddStaff (temp);

		//Sonia Boccardo
		temp = new Staff ();
		temp.SetName ("Sonia Boccardo");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("3.014");
		temp.AddPhone ("9360 6679");
		temp.SetEmail ("S.Boccardo@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Senior Librarian Reference and Liaison Services");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Library and Information Services Office");
		temp.AddOrganisation ("Client Services and Information Access");
		temp.AddOrganisation("Library Resource Services");
		//add to staff manager
		sm.AddStaff (temp);

		//Ghylene Palmer
		temp = new Staff ();
		temp.SetName ("Ghylene Palmer");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("3.015");
		temp.AddPhone ("9360 2763");
		temp.SetEmail ("G.Palmer@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Acting Manager Library Client Services");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Library and Information Services Office");
		temp.AddOrganisation ("Client Services and Information Access");
		temp.AddOrganisation("Library Client Services");
		//add to staff manager
		sm.AddStaff (temp);

		//Joanne Lisciandro
		temp = new Staff ();
		temp.SetName ("Joanne Lisciandro");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("4.002A");
		temp.AddPhone ("9360 6258");
		temp.SetEmail ("J.Lisciandro@murdoch.edu.au");
		temp.SetPhoto ("902.jpg");
		temp.SetPosition ("Lecturer - OnTrack");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Centre for University Teaching and Learning");
		//add to staff manager
		sm.AddStaff (temp);

		//Jodie-Lee McLeod
		temp = new Staff ();
		temp.SetName ("Jodie-Lee McLeod");
		temp.SetBuildingNo ("350");
		temp.SetOfficeNo("4.002B");
		temp.AddPhone ("9360 6220");
		temp.SetEmail ("J.McLeod@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Postgraduate Training Coordinator");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Centre for University Teaching and Learning");
		//add to staff manager
		sm.AddStaff (temp);

		//building 460
		//Andrew Syme
		temp = new Staff ();
		temp.SetName ("Andrew Syme");
		temp.SetBuildingNo ("460");
		temp.SetOfficeNo("4.007");
		temp.AddPhone ("9360 7421");
		temp.SetEmail ("A.Syme@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Senior Database Coordinator");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Library and Information Services Office");
		temp.AddOrganisation ("Information Systems and Infrastructure");
		temp.AddOrganisation ("Computer Services");
		//add to staff manager
		sm.AddStaff (temp);

		//Abigayle Carmody
		temp = new Staff ();
		temp.SetName ("Abigayle Carmody");
		temp.SetBuildingNo ("460");
		temp.SetOfficeNo("1.007");
		temp.AddPhone ("9360 2719");
		temp.SetEmail ("A.Carmody@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Equity Projects Officer");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Student Services");
		temp.AddOrganisation ("Equity & Social Inclusion");
		//add to staff manager
		sm.AddStaff (temp);

		//Nikola Horley
		temp = new Staff ();
		temp.SetName ("Supratik Mukherji");
		temp.SetBuildingNo ("460");
		temp.SetOfficeNo("1.011");
		temp.AddPhone ("9360 6152");
		temp.SetEmail ("N.Horley@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Student Disability Advisor");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Student Services");
		temp.AddOrganisation ("Equity & Social Inclusion");
		//add to staff manager
		sm.AddStaff (temp);

		//Supratik Mukherji
		temp = new Staff ();
		temp.SetName ("Supratik Mukherji");
		temp.SetBuildingNo ("460");
		temp.SetOfficeNo("1.014");
		temp.AddPhone ("9360 6060");
		temp.SetEmail ("s.mukherji@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Student Disability Advisor");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("Student Services");
		temp.AddOrganisation ("Equity & Social Inclusion");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Courtney Field
		temp = new Staff ();
		temp.SetName ("Dr Courtney Field");
		temp.SetBuildingNo ("460");
		temp.SetOfficeNo("2.006");
		temp.AddPhone ("9360 2319");
		temp.SetEmail ("C.Field@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Law");
		//add to staff manager
		sm.AddStaff (temp);

		//building 330
		//Linda Barton
		temp = new Staff ();
		temp.SetName ("Linda Barton");
		temp.SetBuildingNo ("330");
		temp.SetOfficeNo("3.023");
		temp.AddPhone ("9360 6435");
		temp.SetEmail ("L.Barton@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Manager HR Systems and Projects");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Human Resources Office");
		temp.AddOrganisation ("HR Systems");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Erich von Dietze
		temp = new Staff ();
		temp.SetName ("Dr Erich von Dietze");
		temp.SetBuildingNo ("330");
		temp.SetOfficeNo("1.006");
		temp.AddPhone ("9360 6170");
		temp.SetEmail ("E.vonDietze@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Manager Research Ethics");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Research And Development Office");
		temp.AddOrganisation ("Directorate Research & Development Office");
		temp.AddOrganisation ("Research Ethics");
		//add to staff manager
		sm.AddStaff (temp);

		//Dr Graham O'Hara
		temp = new Staff ();
		temp.SetName ("Dr Graham O'Hara");
		temp.SetBuildingNo ("330");
		temp.SetOfficeNo("1.009");
		temp.AddPhone ("9360 2583");
		temp.SetEmail ("G.Ohara@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Senior Lecturer");
		temp.AddOrganisation ("Academy");
		temp.AddOrganisation ("School of Veterinary and Life Sciences");
		temp.AddOrganisation ("Agricultural Sciences");
		//add to staff manager
		sm.AddStaff (temp);

		//Joanne Hulme
		temp = new Staff ();
		temp.SetName ("Joanne Hulme");
		temp.SetBuildingNo ("330");
		temp.SetOfficeNo("2.005");
		temp.AddPhone ("9360 6352");
		temp.SetEmail ("J.Hulme@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("Domestic Admissions Coordinator");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		temp.AddOrganisation ("External Engagement");
		temp.AddOrganisation("Admissions and Recruitment Support");
		//add to staff manager
		sm.AddStaff (temp);

		//Paul Comiskey
		temp = new Staff ();
		temp.SetName ("Paul Comiskey");
		temp.SetBuildingNo ("330");
		temp.SetOfficeNo("2.009");
		temp.AddPhone ("9360 7812");
		temp.SetEmail ("P.Comiskey@murdoch.edu.au");
		temp.SetPhoto ("none");
		temp.SetPosition ("MUCC Curriculum Manager ");
		temp.AddOrganisation ("Professional Services");
		temp.AddOrganisation ("Academic Registrar's Office");
		//add to staff manager
		sm.AddStaff (temp);

//		//Load staff data here
//		string dirInfo = Application.dataPath + "/Resources/Staff";
//		string[] subdirectories = Directory.GetDirectories (dirInfo);
//		
//		foreach (string d in subdirectories) //for each directory
//		{
//			Staff temp = new Staff ();
//			DirectoryInfo dir = new DirectoryInfo(d);
//			FileInfo[] files = dir.GetFiles(); //get list of files in the directory
//
//			foreach(FileInfo f in files) //for each file in the directory
//			{
//				if(!f.Name.Contains("meta")) //ignore if file name contains "meta" substring
//				{
//					string path = dir.Name;
//					string file = Path.GetFileNameWithoutExtension(f.Name);
//					TextAsset txtfile = Resources.Load("Staff/" + path + "/" + file) as TextAsset;
//					char[] separators = {'\n'};
//					string[] linesFromfile = txtfile.text.Split (separators);
//					string[] tokens;
//
//					//phones
//					int pIndex = 4; //index of first occupant
//					tokens = linesFromfile[pIndex-1].Split(':'); //split "Number of Phones: " string
//					int pCount = Int32.Parse (tokens[1].Trim()); //get number of phones
//					//Debug.Log(pIndex + " " + pCount);
//
//					//organisations
//					int oIndex = pIndex + pCount + 4; //index of first service
//					tokens = linesFromfile[oIndex-1].Split(':'); //split "Number of Organisations: " string
//					int oCount = Int32.Parse (tokens[1].Trim()); //get the number of organisations
//					//Debug.Log(oIndex + " " + oCount);
//
//					//set staff name
//					tokens = linesFromfile[0].Split(':');
//					temp.SetName(tokens[1].Trim());
//
//					//set building number
//					tokens = linesFromfile[1].Split(':');
//					temp.SetBuildingNo(tokens[1].Trim());
//
//					//set office number
//					tokens = linesFromfile[2].Split(':');
//					temp.SetOfficeNo(tokens[1].Trim());
//
//					//add phones
//					for(int i=pIndex; i<pIndex + pCount; i++)
//					{
//						temp.AddPhone(linesFromfile[i]);
//					}
//
//					//set email
//					tokens = linesFromfile[oIndex - 4].Split(':');
//					temp.SetEmail(tokens[1].Trim());
//
//					//set photo
//					tokens = linesFromfile[oIndex - 3].Split(':');
//					temp.SetPhoto(tokens[1].Trim());
//
//					//set position
//					tokens = linesFromfile[oIndex - 2].Split(':');
//					temp.SetPosition(tokens[1].Trim());
//
//					//add organisations
//					for(int i=oIndex; i<oIndex + oCount; i++)
//					{
//						temp.AddOrganisation(linesFromfile[i]);
//					}
//				}
//
//				sm.AddStaff (temp); //add the staff to the list
//			}
//		}

//		Debug.Log (">>>No Staff");
//		Debug.Log(sm.NumberOfStaff().ToString());
//
//		for(int i=0; i<sm.NumberOfStaff(); i++)
//		{
//			Debug.Log (">>>Staff Member");
//			Debug.Log(sm.GetStaffAt(i).GetName());
//			Debug.Log(sm.GetStaffAt(i).GetBuildingNo());
//			Debug.Log(sm.GetStaffAt(i).GetOfficeNo());
//
//			Debug.Log (">>>Phones");
//			for(int j=0; j<sm.GetStaffAt(i).NumberOfPhones(); j++)
//				Debug.Log(sm.GetStaffAt(i).GetPhoneAt(j));
//
//			Debug.Log(sm.GetStaffAt(i).GetEmail());
//			Debug.Log(sm.GetStaffAt(i).GetPhoto());
//			Debug.Log(sm.GetStaffAt(i).GetPosition());
//
//			Debug.Log (">>>Organisations");
//			for(int j=0; j<sm.GetStaffAt(i).NumberOfOrganisations(); j++)
//				Debug.Log(sm.GetStaffAt(i).GetOrganisationAt(j));
//		}
	}

	/// <summary>
	/// Loads the lecture data.
	/// </summary>
	void LoadLectureData()
	{
		Lecture temp;

		//building 245
		temp = new Lecture (8, "ICT167", "Principles of Computer Science", "Tuesday", "13:30", "15:30", "RLT");
		//add lecture to lecture manager
		lm.AddLecture (temp);
		temp = new Lecture (1, "ICT169", "Foundations of Data Communications", "Monday", "14:30", "16:30", "ECL4");
		lm.AddLecture (temp);
		temp = new Lecture (2, "ICT207", "Games Design & Programming", "Monday", "09:30", "11:30", "AMEN2.024");
		lm.AddLecture (temp);
		temp = new Lecture (3, "ICT211", "Web Computing", "Monday", "12:30", "14:30", "VBS3.023");
		lm.AddLecture (temp);
		temp = new Lecture (4, "ICT265", "Knowledge and Information Security", "Monday", "14:30", "16:30", "LBLT");
		lm.AddLecture (temp);
		temp = new Lecture (5, "ICT347", "Advanced Network Design", "Monday", "14:30", "16:30", "SS1.036");
		lm.AddLecture (temp);
		temp = new Lecture (6, "ICT535", "Advanced Business Data Communications", "Monday", "16:30", "18:30", "Law1.103");
		lm.AddLecture (temp);
		temp = new Lecture (7, "ICT619", "Intelligent Systems Applications", "Monday", "16:30", "19:30", "AMEN2.023");
		lm.AddLecture (temp);
		temp = new Lecture (8, "ICT167", "Principles of Computer Science", "Tuesday", "13:30", "15:30", "RLT");
		lm.AddLecture (temp);
		temp = new Lecture (9, "ICT170", "Foundations of Computer Systems", "Tuesday", "08:30", "10:30", "ECL2");
		lm.AddLecture (temp);
		temp = new Lecture (10, "ICT245", "Games Software Production", "Tuesday", "12:30", "14:30", "AMEN2.024");
		lm.AddLecture (temp);
		temp = new Lecture (11, "ICT310", "Op Syst and Syst Program", "Tuesday", "14:30", "16:30", "VBS3.023");
		lm.AddLecture (temp);
		temp = new Lecture (12, "ICT312", "Virtual Env for Games & Simulations", "Tuesday", "16:30", "18:30", "AMEN2.023");
		lm.AddLecture (temp);
		temp = new Lecture (13, "ICT616", "Data Resources Management", "Tuesday", "16:30", "19:30", "AMEN2.024");
		lm.AddLecture (temp);
		temp = new Lecture (14, "ICT218", "Databases", "Wednesday", "14:30", "16:30", "VBS3.024");
		lm.AddLecture (temp);
		temp = new Lecture (15, "ICT219", "Intelligent Systems", "Wednesday", "11:30", "13:30", "VBS3.023");
		lm.AddLecture (temp);
		temp = new Lecture (16, "ICT313", "Games Technology Project", "Wednesday", "08:30", "10:30", "ECL3");
		lm.AddLecture (temp);
		temp = new Lecture (17, "ICT333", "Info Tech Project", "Wednesday", "08:30", "10:30", "ECL3");
		lm.AddLecture (temp);
		temp = new Lecture (18, "ICT158", "Introduction to Information Systems", "Thursday", "09:30", "11:30", "BSLT");
		lm.AddLecture (temp);
		temp = new Lecture (19, "ICT357", "Information Security Management", "Thursday", "13:30", "15:30", "VBS3.023");
		lm.AddLecture (temp);
		temp = new Lecture (20, "ICT622", "Information Technology Strategy", "Thursday", "16:30", "19:30", "BSLT");
		lm.AddLecture (temp);
		temp = new Lecture (21, "ICT264", "Wireless Networks", "Friday", "13:30", "15:30", "ECL3");
		lm.AddLecture (temp);

//		//Load lecture data here
//		TextAsset txtfile = Resources.Load("Lectures/lecture_info") as TextAsset;
//		char[] separators = {'\n'};
//		string[] linesFromfile = txtfile.text.Split (separators);
//		string[] tokens;
//
//		foreach (string line in linesFromfile)
//		{
//			Lecture temp = new Lecture ();
//			tokens = line.Split (';');
//
//			temp.SetID(Int32.Parse(tokens[0]));
//			temp.SetUnitCode(tokens[1]);
//			temp.SetUnitName(tokens[2]);
//			temp.SetDay(tokens[3]);
//			temp.SetStart(tokens[4]);
//			temp.SetEnd(tokens[5]);
//			temp.SetRoom(tokens[6]);
//
//			lm.AddLecture(temp); //add lecture to lecture list

			//Debug.Log(temp.GetID() + " " + temp.GetUnitCode() + " " +  temp.GetUnitName() + " " +  temp.GetDay() 
			//          + " " +  temp.GetStart() + " " +  temp.GetEnd() + " " +  temp.GetRoom());
//		}
	}
}