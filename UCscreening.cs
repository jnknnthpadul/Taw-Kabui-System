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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PAD'Z\Documents\TawKabuiDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Assesment;
        string LPO;
        string PSex;
        string Pcategory;
        string Support;
        string Fps;
        string House;
        string Community;
        string Resources;


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

            listBox1.Items.Clear();
            foreach (string s in clbPrograms.CheckedItems)
            listBox1.Items.Add(s);

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

                SqlCommand cmd = new SqlCommand("INSERT into FormATB(ChildID,Interview,Time,ChildName,Nickname,BirthDate,InformantName,Address,Relationship,Contact1,Network1,Contact2,Network2,InformantWho,InformantWhat,InformantWhen,InformantHow,Assesment,Pertinent,Agencies,Programs,Others,LPO) values(@ChildID,@Interview,@Time,@ChildName,@Nickname,@BirthDate,@InformantName,@Address,@Relationship,@Contact1,@Network1,@Contact2,@Network2,@InformantWho,@InformantWhat,@InformantWhen,@InformantHow,@Assesment,@Pertinent,@Agencies,@Programs,@Others,@LPO)", con);
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
                cmd.Parameters.AddWithValue("@Programs", tbChildID.Text);
                cmd.Parameters.AddWithValue("@Others", tbOtherfa.Text);
                cmd.Parameters.AddWithValue("@LPO", LPO);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Form A Save");
            }

        private void btnfbSave_Click(object sender, EventArgs e)
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

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into FormBTB(Interview,Time,ChildID,ChildName,Nickname,Age,Address,BirthDate,BirthPlace,Sex,Nationality,Religion,Ethnic,CurrentIntervention,Education,CurrentSchoolLevel,NameSCH,Category,Reason1,GradeAttained,StopSchool,Reason2,PWDid,DateIssued,Support,HowOften,Fourps,Membership,PhilhealthMem,Type,House,Staying,Other,HouseMade,HouseLocation,Fuel,Rooms,Bathroom,Note) values(@Interview,@Time,@ChildID,@ChildName,@Nickname,@Age,@Address,@BirthDate,@BirthPlace,@Sex,@Nationality,@Religion,@Ethnic,@CurrentIntervention,@Education,@CurrentSchoolLevel,@NameSCH,@Category,@Reason1,@GradeAttained,@StopSchool,@Reason2,@PWDid,@DateIssued,@Support,@HowOften,@Fourps,@Membership,@PhilhealthMem,@Type,@House,@Staying,@Other,@HouseMade,@HouseLocation,@Fuel,@Rooms,@Bathroom,@Note)", con);
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
            con.Close();
            MessageBox.Show("Form B Save");
        }

        private void rbRural_CheckedChanged(object sender, EventArgs e)
        {
            Community = "Rural";
        }

        private void rbUrvan_CheckedChanged(object sender, EventArgs e)
        {
            Community = "Urvan";
        }

        private void chckDayCare_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Day Care";
        }

        private void chckHealthCenter_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Health Center";
        }

        private void chckBirthing_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Lying in/Birthing Center";
        }

        private void chckHPublic_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Hospital (Public)";
        }

        private void chckHPrivate_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Hospital (Private)";
        }

        private void chckGESPublic_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "General Education School (Public)";
        }

        private void chckGESPrivate_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "General Education School(Private)";
        }

        private void chckSCCPublic_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Self-contained Center(Public) ";
        }

        private void chckSCCPrivate_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Self-contained Center(Private) ";
        }

        private void chckTCPublic_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Therapy Center (Public)";
        }

        private void chckTCPrivate_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Therapy Center (Private)";
        }

        private void chckPPP_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Playground/Park/Plaza";
        }

        private void chckCoveredGym_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Covered Gym";
        }

        private void chckMarket_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Market";
        }

        private void chckMall_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Mall";
        }

        private void chckBusiness_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Business Establishment";
        }

        private void chckFactory_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Factory";
        }

        private void chckWorkship_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Place to worship";
        }

        private void chckEvacuation_CheckedChanged(object sender, EventArgs e)
        {
            Resources = "Evacuation Center";
        }
    }
    }