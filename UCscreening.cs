using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taw_Kabui_Management_System
{
    public partial class UCscreening : UserControl
    {
        private static UCscreening _instance;
        public static UCscreening Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCscreening();
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Desktop\Taw Kabui Management System\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Assesment,LPO,PSex,Pcategory,Support,Fps,House,community,HSex,ESex,NSex,PWD,senior,checkup,stat,rec,cup;

        private void BtnOtherFamily_Click(object sender, EventArgs e)
        {
            if (rdOTHyes.Checked == true)
            {
                PWD = "Yes";
            }
            if (rbOTHno.Checked == true)
            {
                PWD = "No";
            }
            if (rbSCyes.Checked == true)
            {
                senior = "Yes";
            }
            if (rbSCno.Checked == true)
            {
                senior = "No";
            }
            con.Open();
            SqlCommand cmd5 = new SqlCommand("INSERT into OthFamTB(ChildID,Name,Age,Illnesses,Impairment,PWD,PWDid,Senior) values(@ChildID,@Name,@Age,@Illnesses,@Impairment,@PWD,@PWDid,@Senior)", con);
            cmd5.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd5.Parameters.AddWithValue("@Name", tbOTHname.Text);
            cmd5.Parameters.AddWithValue("@Age", tbOTHage.Text);
            cmd5.Parameters.AddWithValue("@Illnesses", tbOTHill.Text);
            cmd5.Parameters.AddWithValue("@Impairment", tbOTHimp.Text);
            cmd5.Parameters.AddWithValue("@PWD", PWD);
            cmd5.Parameters.AddWithValue("@PWDid", tbOTHid.Text);
            cmd5.Parameters.AddWithValue("@Senior", senior);
            cmd5.ExecuteNonQuery();
            con.Close();
        }

        private void btnNonFamily_Click(object sender, EventArgs e)
        {
            if (rbNONmale.Checked == true)
            {
                NSex = "Male";
            }
            if (rbNONfemale.Checked == true)
            {
                NSex = "Female";
            }
            con.Open();
            SqlCommand cmd4 = new SqlCommand("INSERT into NonFamTB(ChildID,Name,BirthDate,Relationship,Sex,CivilStatus) values(@ChildID,@Name,@BirthDate,@Relationship,@Sex,@CivilStatus)", con);
            cmd4.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd4.Parameters.AddWithValue("@Name", tbNONname.Text);
            cmd4.Parameters.AddWithValue("@BirthDate", dtpNONdob.Value);
            cmd4.Parameters.AddWithValue("@Relationship", tbNONrelationship.Text);
            cmd4.Parameters.AddWithValue("@Sex", NSex);
            cmd4.Parameters.AddWithValue("@CivilStatus", cbNONcivil.SelectedItem.ToString());
            cmd4.ExecuteNonQuery();
            con.Close ();
        }

        private void btnExtended_Click(object sender, EventArgs e)
        {
            if (rbEXTmale.Checked == true)
            {
                ESex = "Male";
            }
            if (rbEXTfemale.Checked == true)
            {
                ESex = "Female";
            }
            con.Open();
            SqlCommand cmd3 = new SqlCommand("INSERT into ExtendedTB(ChildID,Name,BirthDate,CivilStatus,Sex,Age,Contact,Income,Relationship,Occupation,Attainment,Status) values(@ChildID,@Name,@BirthDate,@CivilStatus,@Sex,@Age,@Contact,@Income,@Relationship,@Occupation,@Attainment,@Status)", con);
            cmd3.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd3.Parameters.AddWithValue("@Name", tbEXTname.Text);
            cmd3.Parameters.AddWithValue("@BirthDate", dtpEXTdob.Value);
            cmd3.Parameters.AddWithValue("@CivilStatus", cbEXTcivil.SelectedItem.ToString());
            cmd3.Parameters.AddWithValue("@Sex", ESex);
            cmd3.Parameters.AddWithValue("@Age", tbEXTage.Text);
            cmd3.Parameters.AddWithValue("@Contact", tbEXTage.Text);
            cmd3.Parameters.AddWithValue("@Income", tbEXTincome.Text);
            cmd3.Parameters.AddWithValue("@Relationship", tbEXTrelationship.Text);
            cmd3.Parameters.AddWithValue("@Occupation", tbEXToccupation.Text);
            cmd3.Parameters.AddWithValue("@Attainment", tbEXTattainment.Text);
            cmd3.Parameters.AddWithValue("@Status", cbEXTstatus.SelectedItem.ToString());
            cmd3.ExecuteNonQuery();
            con.Close();
        }

        private void btnHousehold_Click(object sender, EventArgs e)
        {
            if (rbPOHmale.Checked == true)
            {
                HSex = "Male";
            }
            if (rbPOHfemale.Checked == true)
            {
                HSex = "Female";
            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT into HouseholdTB(ChildID,Name,BirthDate,CivilStatus,Sex,Age,Contact,Income,Relationship,Occupation,Attainment,Status) values(@ChildID,@Name,@BirthDate,@CivilStatus,@Sex,@Age,@Contact,@Income,@Relationship,@Occupation,@Attainment,@Status)", con);
            cmd2.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd2.Parameters.AddWithValue("@Name", tbPOHName.Text);
            cmd2.Parameters.AddWithValue("@BirthDate", dtpPOHdob.Value);
            cmd2.Parameters.AddWithValue("@CivilStatus", tbCivilStatus.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("@Sex", HSex);
            cmd2.Parameters.AddWithValue("@Age", tbPOHage.Text);
            cmd2.Parameters.AddWithValue("@Contact", tbPOHcontact.Text);
            cmd2.Parameters.AddWithValue("@Income", tbPOHIncome.Text);
            cmd2.Parameters.AddWithValue("@Relationship", tbROHRelationship.Text);
            cmd2.Parameters.AddWithValue("@Occupation", tbPOHoccupation.Text);
            cmd2.Parameters.AddWithValue("@Attainment", tbPOHAttainment.Text);
            cmd2.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public UCscreening()
        {
            InitializeComponent();
        }

        private void btnInformant_Click(object sender, EventArgs e)
        {
            Form infomant = new InformantCopyForm();
            infomant.Show();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            if (rbDiagnosis.Checked == true)
            {
                Assesment = "Diagnosis";
            }
            if (rbImpression.Checked == true)
            {
                Assesment = "Impression";
            }
            if (rbLPOyes.Checked == true)
            {
                LPO = "Yes";
            }
            if (rbLPOno.Checked == true)
            {
                LPO = "No";
            }

            con.Open();

                SqlCommand cmd = new SqlCommand("INSERT into FormATB(ChildID,Interview,Time,ChildName,Nickname,BirthDate,InformantName,Address,Relationship,Contact1,Network1,Contact2,Network2,InformantWho,InformantWhat,InformantWhen,InformantHow,Assesment,Pertinent,Agencies,DoNow,DoNext,DoLast,Others,LPO) values(@ChildID,@Interview,@Time,@ChildName,@Nickname,@BirthDate,@InformantName,@Address,@Relationship,@Contact1,@Network1,@Contact2,@Network2,@InformantWho,@InformantWhat,@InformantWhen,@InformantHow,@Assesment,@Pertinent,@Agencies,@DoNow,@DoNext,@DoLast,@Others,@LPO)", con);
                cmd.Parameters.AddWithValue("@ChildID", tbChildID.Text);
                cmd.Parameters.AddWithValue("@Interview", dtpInterview.Value);
                cmd.Parameters.AddWithValue("@Time", tbTime.Text);
                cmd.Parameters.AddWithValue("@ChildName", tbChildName.Text);
                cmd.Parameters.AddWithValue("@Nickname", tbNickname.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                cmd.Parameters.AddWithValue("@InformantName", tbInformantName.Text);
                cmd.Parameters.AddWithValue("@Address", tbInformantAddress.Text);
                cmd.Parameters.AddWithValue("@Relationship", tbInformantRelationship.Text);
                cmd.Parameters.AddWithValue("@Contact1", tbInformantContact1.Text);
                cmd.Parameters.AddWithValue("@Network1", tbInformantNetwork1.Text);
                cmd.Parameters.AddWithValue("@Contact2", tbInformantContact2.Text);
                cmd.Parameters.AddWithValue("@Network2", tbInformantNetwork2.Text);
                cmd.Parameters.AddWithValue("@InformantWho", tbInformantWho.Text);
                cmd.Parameters.AddWithValue("@InformantWhat", tbInformantWhat.Text);
                cmd.Parameters.AddWithValue("@InformantWhen", tbInformantWhen.Text);
                cmd.Parameters.AddWithValue("@InformantHow", tbInformantHow.Text);
                cmd.Parameters.AddWithValue("@Assesment", Assesment);
                cmd.Parameters.AddWithValue("@Pertinent", tbPertinent.Text);
                cmd.Parameters.AddWithValue("@Agencies", tbAgencies.Text);
                cmd.Parameters.AddWithValue("@DoNow", cbDoNow.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DoNext", cbDoNext.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DoLast", cbDoLast.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Others", tbOtherProgram.Text);
                cmd.Parameters.AddWithValue("@LPO", LPO);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Form A Save");
            }



        private void button2_Click_1(object sender, EventArgs e)
        {
            if (rbProfileMale.Checked == true)
            {
                PSex = "Male";
            }
            if (rbProfileFemale.Checked == true)
            {
                PSex = "Female";
            }
            if (rbPublic.Checked == true)
            {
                Pcategory = "Public";
            }
            if (rbPrivate.Checked == true)
            {
                Pcategory = "Private";
            }
            if (rbSupportYES.Checked == true)
            {
                Support = "Yes";
            }
            if (rbSupportNO.Checked == true)
            {
                Support = "No";
            }
            if (rb4psYES.Checked == true)
            {
                Fps = "Yes";
            }
            if (rb4psNO.Checked == true)
            {
                Fps = "No";
            }
            if (rbOwned.Checked == true)
            {
                House = "Owned";
            }
            if (rbRented.Checked == true)
            {
                House = "Rented";
            }

            if (rbRural.Checked == true)
            {
                community = "Rural";
            }
            if (rbUrvan.Checked == true)
            {
                community = "Urvan";
            }
            if (rbPOHmale.Checked == true)
            {
                HSex = "Male";
            }
            if (rbPOHfemale.Checked == true)
            {
                HSex = "Female";
            }
            if (rbEXTmale.Checked == true)
            {
                ESex = "Male";
            }
            if (rbEXTfemale.Checked == true)
            {
                ESex = "Female";
            }
            if (rbNONmale.Checked == true)
            {
                NSex = "Male";
            }
            if (rbNONfemale.Checked == true)
            {
                NSex = "Female";
            }
            if (rdOTHyes.Checked == true)
            {
                PWD = "Yes";
            }
            if (rbOTHno.Checked == true)
            {
                PWD = "No";
            }
            if (rbSCyes.Checked == true)
            {
                senior = "Yes";
            }
            if (rbSCno.Checked == true)
            {
                senior = "No";
            }
            if (rbPregYes.Checked == true)
            {
                checkup = "Yes";
            }
            if (rbPregNo.Checked == true)
            {
                checkup = "No";
            }

            if (rbSTATdiag.Checked == true)
            {
                stat = "Diagnosed";
            }
            if (rbSTATnotdiag.Checked == true)
            {
                stat = "Not Diagnosed";
            }
            if (rbSTATongoing.Checked == true)
            {
                stat = "On Going";
            }
            if (rbRECdiag.Checked == true)
            {
                rec = "Diagnosed";
            }
            if (rbRECnotdiag.Checked == true)
            {
                rec = "Not Diagnosed";
            }
            if (rbRECongoing.Checked == true)
            {
                rec = "On Going";
            }
            if (rbCheckupYES.Checked == true)
            {
                cup = "Yes";
            }
            if (rbCheckupNO.Checked == true)
            {
                cup = "No";
            }

            string Expenses = "";
            foreach (var checkedItem in this.clbExpenses.CheckedItems)
            {

                Expenses += checkedItem.ToString() + ",";

            }
            Expenses = Expenses.TrimEnd(',');


            string Resource = "";
            foreach (var checkedItem in this.clbResource.CheckedItems)
            {

                Resource += checkedItem.ToString() + ",";

            }
            Resource = Resource.TrimEnd(',');

            string Lifestyle = "";
            foreach (var checkedItem in this.clbResource.CheckedItems)
            {

                Lifestyle += checkedItem.ToString() + ",";

            }
            Lifestyle = Lifestyle.TrimEnd(',');

            

            string Specialist = "";
            foreach (var checkedItem in this.clbSpecialist.CheckedItems)
            {

                Specialist += checkedItem.ToString() + ",";

            }
            Specialist = Specialist.TrimEnd(',');

            string Perinatal = "";
            foreach (var checkedItem in this.clbPerinatal.CheckedItems)
            {

                Perinatal += checkedItem.ToString() + ",";

            }
            Perinatal = Perinatal.TrimEnd(',');

            string Postnatal = "";
            foreach (var checkedItem in this.clbPostnatal.CheckedItems)
            {

                Postnatal += checkedItem.ToString() + ",";

            }
            Postnatal = Postnatal.TrimEnd(',');

            string Early = "";
            foreach (var checkedItem in this.clbEarlyIntervention.CheckedItems)
            {

                Early += checkedItem.ToString() + ",";

            }
            Early = Early.TrimEnd(',');

            string Vaccination = "";
            foreach (var checkedItem in this.clbVaccination.CheckedItems)
            {

                Vaccination += checkedItem.ToString() + ",";

            }
            Vaccination = Vaccination.TrimEnd(',');



            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into FormBTB(Interview,Time,ChildID,ChildName,Nickname,Age,Address,BirthDate,BirthPlace,Sex,Nationality,Religion,Ethnic,CurrentIntervention,Education,CurrentSchoolLevel,NameSCH,Category,Reason1,GradeAttained,StopSchool,Reason2,PWDid,DateIssued,Expenses,Support,HowOften,Fourps,Membership,PhilhealthMem,Type,House,Staying,Other,HouseMade,HouseLocation,Fuel,Rooms,Bathroom,Note) values(@Interview,@Time,@ChildID,@ChildName,@Nickname,@Age,@Address,@BirthDate,@BirthPlace,@Sex,@Nationality,@Religion,@Ethnic,@CurrentIntervention,@Education,@CurrentSchoolLevel,@NameSCH,@Category,@Reason1,@GradeAttained,@StopSchool,@Reason2,@PWDid,@DateIssued,@Expenses,@Support,@HowOften,@Fourps,@Membership,@PhilhealthMem,@Type,@House,@Staying,@Other,@HouseMade,@HouseLocation,@Fuel,@Rooms,@Bathroom,@Note)", con);
            cmd.Parameters.AddWithValue("@Interview", dtpInterviewfb.Value);
            cmd.Parameters.AddWithValue("@Time", tbTimefb.Text);
            cmd.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd.Parameters.AddWithValue("@ChildName", tbProfileName.Text);
            cmd.Parameters.AddWithValue("@Nickname", tbProfileNickname.Text);
            cmd.Parameters.AddWithValue("@Age", tbProfileAge.Text);
            cmd.Parameters.AddWithValue("@Address", tbProfileAddress.Text);
            cmd.Parameters.AddWithValue("@BirthDate", dtpProfileDOB.Value);
            cmd.Parameters.AddWithValue("@BirthPlace", tbProfilePOB.Text);
            cmd.Parameters.AddWithValue("@Sex", PSex);
            cmd.Parameters.AddWithValue("@Nationality", tbProfileNationality.Text);
            cmd.Parameters.AddWithValue("@Religion", tbProfileReligion.Text);
            cmd.Parameters.AddWithValue("@Ethnic", tbEthics.Text);
            cmd.Parameters.AddWithValue("@CurrentIntervention", tbIntervention.Text);
            cmd.Parameters.AddWithValue("@Education", tbEducation.Text);
            cmd.Parameters.AddWithValue("@CurrentSchoolLevel", tbLevel.Text);
            cmd.Parameters.AddWithValue("@NameSCH", tbNameSCH.Text);
            cmd.Parameters.AddWithValue("@Category", Pcategory);
            cmd.Parameters.AddWithValue("@Reason1", tbEnrolled.Text);
            cmd.Parameters.AddWithValue("@GradeAttained", tbAttained.Text);
            cmd.Parameters.AddWithValue("@StopSchool", tbStop.Text);
            cmd.Parameters.AddWithValue("@Reason2", tbTherapy.Text);
            cmd.Parameters.AddWithValue("@PWDid", tbPWDid.Text);
            cmd.Parameters.AddWithValue("@DateIssued", dtpDateIssued.Value);
            cmd.Parameters.AddWithValue("@Expenses", Expenses);
            cmd.Parameters.AddWithValue("@Support", Support);
            cmd.Parameters.AddWithValue("@HowOften", cbOften.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Fourps", Fps);
            cmd.Parameters.AddWithValue("@Membership", tbLGU.Text);
            cmd.Parameters.AddWithValue("@PhilhealthMem", tbPhilhealthMem.Text);
            cmd.Parameters.AddWithValue("@Type", tbType.Text);
            cmd.Parameters.AddWithValue("@House", House);
            cmd.Parameters.AddWithValue("@Staying", tbStaying.Text);
            cmd.Parameters.AddWithValue("@Other", tbPOHothers.Text);
            cmd.Parameters.AddWithValue("@HouseMade", tbMade.Text);
            cmd.Parameters.AddWithValue("@HouseLocation", tbLocation.Text);
            cmd.Parameters.AddWithValue("@Fuel", tbFuel.Text);
            cmd.Parameters.AddWithValue("@Rooms", tbRooms.Text);
            cmd.Parameters.AddWithValue("@Bathroom", tbBathrooms.Text);
            cmd.Parameters.AddWithValue("@Note", rtbPOHnote.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("INSERT into CommunityTB(ChildID,Community,Transportation,Electricity,Water,Resource,Site) values(@ChildID,@Community,@Transportation,@Electricity,@Water,@Resource,@Site)", con);
            cmd1.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd1.Parameters.AddWithValue("@Community", community);
            cmd1.Parameters.AddWithValue("@Transportation", tbMOT.Text);
            cmd1.Parameters.AddWithValue("@Electricity", tbSOE.Text);
            cmd1.Parameters.AddWithValue("@Water", tbSOW.Text);
            cmd1.Parameters.AddWithValue("@Resource", Resource);
            cmd1.Parameters.AddWithValue("@Site", tbSite.Text);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("INSERT into HouseholdTB(ChildID,Name,BirthDate,CivilStatus,Sex,Age,Contact,Income,Relationship,Occupation,Attainment,Status) values(@ChildID,@Name,@BirthDate,@CivilStatus,@Sex,@Age,@Contact,@Income,@Relationship,@Occupation,@Attainment,@Status)", con);
            cmd2.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd2.Parameters.AddWithValue("@Name", tbPOHName.Text);
            cmd2.Parameters.AddWithValue("@BirthDate", dtpPOHdob.Value);
            cmd2.Parameters.AddWithValue("@CivilStatus", tbCivilStatus.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("@Sex", HSex);
            cmd2.Parameters.AddWithValue("@Age", tbPOHage.Text);
            cmd2.Parameters.AddWithValue("@Contact", tbPOHcontact.Text);
            cmd2.Parameters.AddWithValue("@Income", tbPOHIncome.Text);
            cmd2.Parameters.AddWithValue("@Relationship", tbROHRelationship.Text);
            cmd2.Parameters.AddWithValue("@Occupation", tbPOHoccupation.Text);
            cmd2.Parameters.AddWithValue("@Attainment", tbPOHAttainment.Text);
            cmd2.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("INSERT into ExtendedTB(ChildID,Name,BirthDate,CivilStatus,Sex,Age,Contact,Income,Relationship,Occupation,Attainment,Status) values(@ChildID,@Name,@BirthDate,@CivilStatus,@Sex,@Age,@Contact,@Income,@Relationship,@Occupation,@Attainment,@Status)", con);
            cmd3.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd3.Parameters.AddWithValue("@Name", tbEXTname.Text);
            cmd3.Parameters.AddWithValue("@BirthDate", dtpEXTdob.Value);
            cmd3.Parameters.AddWithValue("@CivilStatus", cbEXTcivil.SelectedItem.ToString());
            cmd3.Parameters.AddWithValue("@Sex", ESex);
            cmd3.Parameters.AddWithValue("@Age", tbEXTage.Text);
            cmd3.Parameters.AddWithValue("@Contact", tbEXTage.Text);
            cmd3.Parameters.AddWithValue("@Income", tbEXTincome.Text);
            cmd3.Parameters.AddWithValue("@Relationship", tbEXTrelationship.Text);
            cmd3.Parameters.AddWithValue("@Occupation", tbEXToccupation.Text);
            cmd3.Parameters.AddWithValue("@Attainment", tbEXTattainment.Text);
            cmd3.Parameters.AddWithValue("@Status", cbEXTstatus.SelectedItem.ToString());
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("INSERT into NonFamTB(ChildID,Name,BirthDate,Relationship,Sex,CivilStatus) values(@ChildID,@Name,@BirthDate,@Relationship,@Sex,@CivilStatus)", con);
            cmd4.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd4.Parameters.AddWithValue("@Name", tbNONname.Text);
            cmd4.Parameters.AddWithValue("@BirthDate", dtpNONdob.Value);
            cmd4.Parameters.AddWithValue("@Relationship", tbNONrelationship.Text);
            cmd4.Parameters.AddWithValue("@Sex", NSex);
            cmd4.Parameters.AddWithValue("@CivilStatus", cbNONcivil.SelectedItem.ToString());
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("INSERT into OthFamTB(ChildID,Name,Age,Illnesses,Impairment,PWD,PWDid,Senior) values(@ChildID,@Name,@Age,@Illnesses,@Impairment,@PWD,@PWDid,@Senior)", con);
            cmd5.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd5.Parameters.AddWithValue("@Name", tbOTHname.Text);
            cmd5.Parameters.AddWithValue("@Age", tbOTHage.Text);
            cmd5.Parameters.AddWithValue("@Illnesses", tbOTHill.Text);
            cmd5.Parameters.AddWithValue("@Impairment", tbOTHimp.Text);
            cmd5.Parameters.AddWithValue("@PWD", PWD);
            cmd5.Parameters.AddWithValue("@PWDid", tbOTHid.Text);
            cmd5.Parameters.AddWithValue("@Senior", senior);
            cmd5.ExecuteNonQuery();


            SqlCommand cmd6 = new SqlCommand("INSERT into PregnancyTB(ChildID,Lifestyle,Illnesses,Medication,Delivery,Checkup) values(@ChildID,@Lifestyle,@Illnesses,@Medication,@Delivery,@Checkup)", con);
            cmd6.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd6.Parameters.AddWithValue("@Lifestyle", Lifestyle);
            cmd6.Parameters.AddWithValue("@Illnesses", tbPregIllness.Text);
            cmd6.Parameters.AddWithValue("@Medication", tbPregMed.Text);
            cmd6.Parameters.AddWithValue("@Delivery", cbPregDelivery.SelectedItem.ToString());
            cmd6.Parameters.AddWithValue("@Checkup", checkup);
            cmd6.ExecuteNonQuery();


            SqlCommand cmd7 = new SqlCommand("INSERT into HistoryTB(ChildID,Status,AssesmentDate,AssesmentPlace,Name,Specialist,Asphyxia,Perinatal,Postnatal,Diagnosis,Recommendation,CurrentIntervention,EarlyIntervention,Vaccination,Checkup,CheckupDate,Height,Weight,Reason,LengthStay,Accidents,Illnesses,Traumatic,Medication,Vitamins,Incidents,SleepingSetup,SleepingPlace,SleepingPattern,Person,Relationship,Age,Sex,BehaviorCan,BehaviorCant,CommunicationCan,CommunicationCant,CognitiveCan,CognitiveCant,SocioCan,SocioCant,GrossMotorCan,GrossMotorCant,FineMotorCan,FineMotorCant,SelfHelpCan,SelfHelpCant,Home,School,Community) values(@ChildID,@Status,@AssesmentDate,@AssesmentPlace,@Name,@Specialist,@Asphyxia,@Perinatal,@Postnatal,@Diagnosis,@Recommendation,@CurrentIntervention,@EarlyIntervention,@Vaccination,@Checkup,@CheckupDate,@Height,@Weight,@Reason,@LengthStay,@Accidents,@Illnesses,@Traumatic,@Medication,@Vitamins,@Incidents,@SleepingSetup,@SleepingPlace,@SleepingPattern,@Person,@Relationship,@Age,@Sex,@BehaviorCan,@BehaviorCant,@CommunicationCan,@CommunicationCant,@CognitiveCan,@CognitiveCant,@SocioCan,@SocioCant,@GrossMotorCan,@GrossMotorCant,@FineMotorCan,@FineMotorCant,@SelfHelpCan,@SelfHelpCant,@Home,@School,@Community)", con);
            cmd7.Parameters.AddWithValue("@ChildID", tbChildIDfb.Text);
            cmd7.Parameters.AddWithValue("@Status", stat);
            cmd7.Parameters.AddWithValue("@AssesmentDate", dtpDOA.Value);
            cmd7.Parameters.AddWithValue("@AssesmentPlace", tbPOA.Text);
            cmd7.Parameters.AddWithValue("@Name", tbNOS.Text);
            cmd7.Parameters.AddWithValue("@Specialist", Specialist);
            cmd7.Parameters.AddWithValue("@Asphyxia", tbAsphyxia.Text);
            cmd7.Parameters.AddWithValue("@Perinatal", Perinatal);
            cmd7.Parameters.AddWithValue("@Postnatal", Postnatal);
            cmd7.Parameters.AddWithValue("@Diagnosis", tbDiagnosed.Text);
            cmd7.Parameters.AddWithValue("@Recommendation", rec);
            cmd7.Parameters.AddWithValue("@CurrentIntervention", tbCurrent.Text);
            cmd7.Parameters.AddWithValue("@EarlyIntervention", Early);
            cmd7.Parameters.AddWithValue("@Vaccination", Vaccination);
            cmd7.Parameters.AddWithValue("@Checkup", cup);
            cmd7.Parameters.AddWithValue("@CheckupDate", dtpLstChckup.Value);
            cmd7.Parameters.AddWithValue("@Height", tbHeight.Text);
            cmd7.Parameters.AddWithValue("@Weight", tbWeight.Text);
            cmd7.Parameters.AddWithValue("@Reason", tbReason.Text);
            cmd7.Parameters.AddWithValue("@LengthStay", tbStay.Text);
            cmd7.Parameters.AddWithValue("@Accidents", tbAccidents.Text);
            cmd7.Parameters.AddWithValue("@Illnesses", tbIllness.Text);
            cmd7.Parameters.AddWithValue("@Traumatic", tbTraumatic.Text);
            cmd7.Parameters.AddWithValue("@Medication", tbMedication.Text);
            cmd7.Parameters.AddWithValue("@Vitamins", tbVitamins.Text);
            cmd7.Parameters.AddWithValue("@Incidents", cbIncidents.SelectedItem.ToString());
            cmd7.Parameters.AddWithValue("@SleepingSetup", tbSetup.Text);
            cmd7.Parameters.AddWithValue("@SleepingPlace", tbPlace.Text);
            cmd7.Parameters.AddWithValue("@SleepingPattern", tbPattern.Text);
            cmd7.Parameters.AddWithValue("@Person", tbPerson.Text);
            cmd7.Parameters.AddWithValue("@Relationship", tbCPrelationship.Text);
            cmd7.Parameters.AddWithValue("@Age", tbCPage.Text);
            cmd7.Parameters.AddWithValue("@Sex", cbCPsex.SelectedItem.ToString());
            cmd7.Parameters.AddWithValue("@BehaviorCan", rtbBehaviorCan.Text);
            cmd7.Parameters.AddWithValue("@BehaviorCant", rtbBehaviorCant.Text);
            cmd7.Parameters.AddWithValue("@CommunicationCan", rtbCommunicationCan.Text);
            cmd7.Parameters.AddWithValue("@CommunicationCant", rtnCommunicationCant.Text);
            cmd7.Parameters.AddWithValue("@CognitiveCan", rtbCognativeCan.Text);
            cmd7.Parameters.AddWithValue("@CognitiveCant", rtbCognativeCant.Text);
            cmd7.Parameters.AddWithValue("@SocioCan", rtbSocioCan.Text);
            cmd7.Parameters.AddWithValue("@SocioCant", rtbSocioCant.Text);
            cmd7.Parameters.AddWithValue("@GrossMotorCan", rtbGrossCan.Text);
            cmd7.Parameters.AddWithValue("@GrossMotorCant", rtbGrossCant.Text);
            cmd7.Parameters.AddWithValue("@FineMotorCan", rtbFineCan.Text);
            cmd7.Parameters.AddWithValue("@FineMotorCant", rtbFineCant.Text);
            cmd7.Parameters.AddWithValue("@SelfHelpCan", rtbSelfCan.Text);
            cmd7.Parameters.AddWithValue("@SelfHelpCant", rtbSelfCant.Text);
            cmd7.Parameters.AddWithValue("@Home", rtbHome.Text);
            cmd7.Parameters.AddWithValue("@School", rtbSchool.Text);
            cmd7.Parameters.AddWithValue("@Community", rtbCommunity.Text);
            cmd7.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Save");
        }

    }
}