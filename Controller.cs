using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Dieter
{
    
    public class Controller
    {
        
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
            
        }
        public int SubRegtoDiet(int dID, int dtID)
        {
            string query = "UPDATE Reg_Dieter SET DtID='" + dtID + "' WHERE ID ='" + dID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public int upRegtoDiet(int dID, int Loyalty)
        {
            string query = "UPDATE Reg_Dieter SET Loyalty='" + Loyalty + "' WHERE ID ='" + dID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public int unSubRegtoDiet(int dID)
        {
            string query = "UPDATE Reg_Dieter SET DtID='" + 100004 + "' WHERE ID ='" + dID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public int unSubPremtoDiet(int pID)
        {
            string query = "UPDATE SubPD SET DTID='" + "100004" + "' WHERE PDID ='" + pID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public int unSubPremtoWorkout(int pID)
        {
            string query = "UPDATE SubPD SET WID='" + "100005" + "' WHERE PDID ='" + pID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public DataTable getDietname(int ID)
        {
            string query = "SELECT * FROM Diet WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable getWorkoutname(int ID)
        {
            string query = "SELECT * FROM Work_Out WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable getprogname(int ID)
        {
            string query = "SELECT * FROM program WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable getsubworkout(int ID)
        {
            string query = "SELECT WoID FROM Reg_Dieter WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable getsubdiet(int ID)
        {
            string query = "SELECT DtID FROM Reg_Dieter WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public int SubRegtoWorkout(int dID, int woID)
        {
            string query = "UPDATE Reg_Dieter SET WoID='" + woID + "' WHERE ID ='" + dID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public int unSubRegtoWorkout(int dID)
        {
            string query = "UPDATE Reg_Dieter SET WoID='" + 100005 + "' WHERE ID ='" + dID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateProg(int ID, int calcount, int calburn, int currwt)
        {
            string query = "UPDATE progress_diary SET "+ 
                "Current_Weight='" + currwt + "'," +
                "Daily_calorie_burn='" + calburn + "'," +
                "Daily_calorie_Count='" + calcount + "'" +
                "WHERE DID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateRegDieter(int ID, string Fname, string Lname, int St_Weight)
        {
            string query = "UPDATE Dieter SET " +
                "Fname='" + Fname + "'," +
                "Lname='" + Lname + "'," +
                "St_Weight='" + St_Weight + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateAdminPass(int ID, string pass_word)
        {
            string query = "UPDATE Admin_ SET " +
                "pass_word='" + pass_word + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateRDPass(int ID, string pass_word)
        {
            string query = "UPDATE Reg_Dieter SET " +
                "pass_word='" + pass_word + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdatePDPass(int ID, string pass_word)
        {
            string query = "UPDATE Prem_Dieter SET " +
                "pass_word='" + pass_word + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateNPass(int ID, string Pass_word)
        {
            string query = "UPDATE Nutritionist SET " +
                "Pass_word='" + Pass_word + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateTPass(int ID, string Pass_word)
        {
            string query = "UPDATE trainer SET " +
                "Pass_word='" + Pass_word + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdatePremDieter(int ID, string Payment_Details)
        {
            string query = "UPDATE Prem_Dieter SET " +
                "Payment_Details='" + Payment_Details +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateNutritionist(int ID, string Fname, string Lname, string Degree)
        {
            string query = "UPDATE Nutritionist SET " +
                "Fname='" + Fname + "'," +
                "Lname='" + Lname + "'," +
                "Degree='" + Degree + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int UpdateTrainer(int ID, string Fname, string Lname, string Degree)
        {
            string query = "UPDATE trainer SET " +
                "Fname='" + Fname + "'," +
                "Lname='" + Lname + "'," +
                "Degree='" + Degree + "'" +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int AddDiettoProg(int ID, string Program_Diet_Path)
        {
            string query = "UPDATE program SET " +
                "Program_Diet_Path='" + Program_Diet_Path +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        }
        public int AddWorkouttoProg(int ID, string Program_WorkOuts_Video_Path)
        {
            string query = "UPDATE program SET " +
                "Program_WorkOuts_Video_Path='" + Program_WorkOuts_Video_Path +
                "WHERE ID = " + ID;
            return dbMan.ExecuteNonQuery1(query);
        } 
        public DataTable getpsubdiet(int ID)
        {
            string query = "SELECT DTID FROM SubPD WHERE PDID = " + ID;
            return dbMan.ExecuteReader1(query);    
        }
        public DataTable getpsubworkout(int ID)
        {
            string query = "SELECT WID FROM SubPW WHERE PDID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable getpsubprog(int ID)
        {
            string query = "SELECT PID FROM SubPP WHERE PDID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public int CheckID(int ID)
        {
            string query = "SELECT ID FROM DIETER WHERE ID ='" + ID + "';";
            return dbMan.ExecuteNonQuery1(query);
        }
        public DataTable CheckProgID(int ID)
        {
            string query = "SELECT ID FROM program WHERE ID ='" + ID + "';";
            return dbMan.ExecuteReader1(query);
        }
        public DataTable CheckDietID(int ID)
        {
            string query = "SELECT ID FROM Diet WHERE ID ='" + ID + "';";
            return dbMan.ExecuteReader1(query);
        }
        public DataTable CheckWorkoutID(int ID)
        {
            string query = "SELECT ID FROM Work_Out WHERE ID ='" + ID + "';";
            return dbMan.ExecuteReader1(query);
        }
        public DataTable CheckRecID(int ID)
        {
            string query = "SELECT ID FROM Recipe WHERE ID ='" + ID + "';";
            return dbMan.ExecuteReader1(query);
        }
        public DataTable CheckSuppID(int ID)
        {
            string query = "SELECT ID FROM Supplement WHERE ID ='" + ID + "';";
            return dbMan.ExecuteReader1(query);
        }
        public DataTable CheckGuideID(int ID)
        {
            string query = "SELECT ID FROM Guide WHERE ID ='" + ID + "';";
            return dbMan.ExecuteReader1(query);
        }
        public DataTable getfnameD(int ID)
        {  string query = "SELECT Fname FROM Dieter WHERE ID = '" + ID + "';";
        return dbMan.ExecuteReader1(query);
        }

        //public DataTable getDcalcount(int ID)
        //{
        //    //string Output;
        //    string StoredProcedureName = StoredProcedures.getDcalcount;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
             
        //}
        public DataTable ViewDieter(int ID)
        {
            string query = "SELECT * FROM Dieter WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewPremDieter(int ID)
        {
            string query = "SELECT * FROM Prem_Dieter WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        //public DataTable ViewNutritionist(int ID)
        //{
        //    string query = "SELECT * FROM Nutritionist WHERE ID = " + ID;
        //    return dbMan.ExecuteReader1(query);
        //}
        //public DataTable ViewTrainer(int ID)
        //{
        //    string query = "SELECT * FROM trainer WHERE ID = " + ID;
        //    return dbMan.ExecuteReader1(query);
        //}
        public DataTable ViewDieterProg(int ID)
        {
            string query = "SELECT * FROM progress_diary WHERE DID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewAllDiets()
        {

            string StoredProcedureName = StoredProcedures.ViewAllDiets;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewAllWorkouts()
        {

            string StoredProcedureName = StoredProcedures.ViewAllWorkouts;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewAllPrograms()
        {

            string StoredProcedureName = StoredProcedures.ViewAllPrograms;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewDietByID()
        {

            string StoredProcedureName = StoredProcedures.ViewDietByID;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewTrainers(int ID)
        {

            string query = "SELECT * FROM trainer WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewRegDieters(int ID)
        {

            string query = "SELECT * FROM Reg_Dieter WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewAdmins(int ID)
        {

            string query = "SELECT * FROM Admin_ WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewPremiumDieters(int ID)
        {

            string query = "SELECT * FROM Prem_Dieter WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewNutritionists(int ID)
        {

            string query = "SELECT * FROM Nutritionist WHERE ID = " + ID;
            return dbMan.ExecuteReader1(query);
        }
        public DataTable ViewProgramByID(int id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            string StoredProcedureName = StoredProcedures.ViewProgramByID;
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable ViewProgramByIDN(int id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            string StoredProcedureName = StoredProcedures.ViewNProgramByID;
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable ViewWorkoutByID(int id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            string StoredProcedureName = StoredProcedures.ViewWorkoutByID;
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable ViewDietByID(int id)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            string StoredProcedureName = StoredProcedures.ViewDietByID;
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable ViewAllRecipes()
        {

            string StoredProcedureName = StoredProcedures.ViewAllRecipes;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewAllSupplements()
        {

            string StoredProcedureName = StoredProcedures.ViewAllSupplements;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewAllDietsGuides()
        {

            string StoredProcedureName = StoredProcedures.ViewAllDietsGuides;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable ViewAllCheatGuides()
        {

            string StoredProcedureName = StoredProcedures.ViewAllCheatGuides;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //public string getfnameD(int ID)
        //{
        //    string StoredProcedureName = StoredProcedures.getDieterfname;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //}
        public int InsertAdmin(int ID, string Fname, string Lname, string pass_word, string username)
        {

            string StoredProcedureName = StoredProcedures.InsertNewAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@pass_word", pass_word);
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertDieter(int ID, string Fname, string Lname, int st_weight) 
        {
            
            string StoredProcedureName = StoredProcedures.InsertDieter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@st_weight", st_weight);
 
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertRegDieter(int ID, int Loyalty, string pass_word)
        {
            string StoredProcedureName = StoredProcedures.InsertRegDieter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Loyalty", Loyalty);
            Parameters.Add("@pass_word", pass_word);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertPremDieter(int ID, string Payment_Details, string pass_word)
        {
            string StoredProcedureName = StoredProcedures.InsertPremDieter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Payment_Details", Payment_Details);
            Parameters.Add("@pass_word", pass_word);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertRecipe(int ID, string Title, int Hours_, int Mins, string Energy_Cal, string Carbs_gm, string Protein_gm, string Fats_gm, string Ingredients, string Rec_path, int DID, int NID, int TID)
        {
            string StoredProcedureName = StoredProcedures.InsertRecipe;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Hours_", Hours_);
            Parameters.Add("@Mins", Mins);
            Parameters.Add("@Energy_Cal", Energy_Cal);
            Parameters.Add("@Carbs_gm", Carbs_gm);
            Parameters.Add("@Protein_gm", Protein_gm);
            Parameters.Add("@Fats_gm", Fats_gm);
            Parameters.Add("@Ingredients", Ingredients);
            Parameters.Add("@Rec_path", Rec_path);
            Parameters.Add("@DID", DID);
            Parameters.Add("@NID", NID);
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //add
        public int InsertSuppD(int ID, string Name, int Energy, int Carb, int Protein, int Fats, int Rate, int DID, int NID, int TID)
        {
            string StoredProcedureName = StoredProcedures.InsertSupplementD;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Energy", Energy);
            Parameters.Add("@Carbs", Carb);
            Parameters.Add("@Protein", Protein);
            Parameters.Add("@Fats", Fats);
            Parameters.Add("@Rate", Rate);
            Parameters.Add("@DID", DID);
            Parameters.Add("@NID", NID);
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertDiet(int ID, string Title, string Est_weight_Loss, string Duration, string Diet_Path , int NID)
        {
            string StoredProcedureName = StoredProcedures.InsertDiet;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Est_weight_Loss", Est_weight_Loss);
            Parameters.Add("@Duration", Duration);
            Parameters.Add("@Diet_Path", Diet_Path);
            Parameters.Add("@NID", NID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertWorkOut(int ID, string Title, string Difficulty, string Video_path, int Est_cal_Burn, int Duration_Min, string Type_, int TID)
        {
            string StoredProcedureName = StoredProcedures.InsertWorkOut;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Difficulty", Difficulty);
            Parameters.Add("@Video_path", Video_path);
            Parameters.Add("@Est_cal_Burn", Est_cal_Burn);
            Parameters.Add("@Duration_Min", Duration_Min);
            Parameters.Add("@Type_", Type_);
            Parameters.Add("@TID", TID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertProgram(int ID, string Title,  string Type_, string Period, string Est_Weight_loss, string Program_Diet_Path, string Program_WorkOuts_Video_Path)
        {
            string StoredProcedureName = StoredProcedures.InsertProgram;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Type_", Type_);
            Parameters.Add("@Period", Period);
            Parameters.Add("@Est_Weight_loss", Est_Weight_loss);
            Parameters.Add("@Program_Diet_Path", Program_Diet_Path);

            Parameters.Add("@Program_WorkOuts_Video_Path", Program_WorkOuts_Video_Path);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertProgMaker(int PID, int NID, int TID)
        {
            string StoredProcedureName = StoredProcedures.InsertProg;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@NID", NID);
            Parameters.Add("@TID", TID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertGuide(int ID, string Name, int Rating, string Menu, int DID, int NID,int TID)
        {
            string StoredProcedureName = StoredProcedures.InsertGuide;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Rating", Rating);
            Parameters.Add("@Menu", Menu);
            Parameters.Add("@DID", DID);
            Parameters.Add("@NID", NID);
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertDietGuide(int ID, string Menu_Item)
        {
            string StoredProcedureName = StoredProcedures.InsertDGuide;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Menu_Item", Menu_Item);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertCheatGuide(int ID, string level_of_cheat)
        {
            string StoredProcedureName = StoredProcedures.InsertCGuide;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@level_of_cheat", level_of_cheat);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertGuideNum(int ID, int GNumber)
        {
            string StoredProcedureName = StoredProcedures.InsertGNo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@GNumber", GNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertGuideNum(int ID, string GNumber)
        {
            string StoredProcedureName = StoredProcedures.InsertGNo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@GID", ID);
            Parameters.Add("@GNumber", GNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertGuideAddress(int ID, string GAddress)
        {
            string StoredProcedureName = StoredProcedures.InsertGAdd;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@GID", ID);
            Parameters.Add("@GAddress", GAddress);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertNutritionist(int ID, string Fname, string Lname, string Degree, string Pass_word)
        {
            string StoredProcedureName = StoredProcedures.InsertNut;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Degree", Degree);
            Parameters.Add("@Pass_word", Pass_word);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertTrainer(int ID, string Fname, string Lname, string Degree, string Pass_word)
        {
            string StoredProcedureName = StoredProcedures.InsertTrainer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Degree", Degree);
            Parameters.Add("@Pass_word", Pass_word);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
  
  
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

