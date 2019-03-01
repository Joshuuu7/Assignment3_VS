/********************************************************************************
 * 
 * Programmers: Joshua Flores, Adam Olderr
 * 
 * z-IDs: 1682720, 1753651
 * 
 * Assignment Number : 3
 * 
 * Due Date: February 28, 2018
 * 
 * Class: CSCI504
 * 
 * Instructor: Daniel Rogness
 * 
 * Teaching Assistants: Aravind Muvva, Kiranmayi Manukonda
 * 
 * *******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FloresOlderr_Assignment3
{
    public enum Classes
    {
        Warrior, Mage, Druid, Priest, Warlock,
        Rogue, Paladin, Hunter, Shaman
    };

    public enum Role { Tank, Healer, Damage };

    public enum Race
    {  Orc, Troll, Tauren, Forsaken };

    public partial class Form1 : Form
    {
        static Dictionary<string, string> customGuilds = new Dictionary<string, string>();
        List<Player> player_roster = new List<Player>();
        List<Guild> guilds_roster = new List<Guild>();

        public Form1()
        {
            InitializeComponent();
            ResultsListView = generateListView(ResultsListView);
            ClassComboBox.Items.AddRange(new object[] { "Warrior",
            "Mage",
            "Druid",
            "Priest",
            "Warlock",
            "Rogue",
            "Paladin",
            "Hunter",
            "Shaman" });
            SingleServerComboBox.Items.AddRange(new object[] { "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi" });
            PercentageServerComboBox.Items.AddRange(new object[] { "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi" });
            TypeComboBox.Items.AddRange(new object[] { "Causal", "Questing", "Mythic+", "Raiding", "PVP" });
            RoleComboBox.Items.AddRange(new object[] { "Tank", "Healer", "Damage" });
            RoleServerComboBox.Items.AddRange(new object[] { "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi" });
            player_roster = readPlayers();
            player_roster.Sort((x, y) => x.Name.CompareTo(y.Name));

            guilds_roster = readGuilds();

            foreach (Player p in player_roster)
            {
                foreach (Guild g in guilds_roster)
                {
                    if (p.Guild_ID.Equals(g.ID))
                    {
                        p.SetServer(g.Server);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /********************************************************************************
         * 
         * Method: generateListView
         * 
         * Arguments: ListView type
         * 
         * Return Type: ListView type
         * 
         * Purpose: Creates a ListView of certain width with a vertical scrollbar. 
         * 
         * *******************************************************************************/

        private ListView generateListView(ListView listView)
        {
            listView.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            listView.Columns.Add(header);
            listView.Scrollable = true;
            for (int i = 0; i < listView.Columns.Count - 1; i++)
            {
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            listView.Columns[listView.Columns.Count - 1].Width = -2;
            listView.Columns[0].Width = 900;
            listView.View = System.Windows.Forms.View.Details;
            return listView;
        }

        /********************************************************************************
        * 
        * Method: GetRole
        * 
        * Arguments: string roleID
        * 
        * Return Type: string
        * 
        * Purpose: Determines a Role type from the enum. 
        * 
        * *******************************************************************************/

        public static string GetRole(string roleID)
        {
            string role_string = "";

            switch (roleID)
            {
                case "Tank":
                    role_string = "Tank";
                    break;
                case "Healer":
                    role_string = "Healer";
                    break;
                case "Damage":
                    role_string = "Damage";
                    break;
                case "0":
                    role_string = "Tank";
                    break;
                case "1":
                    role_string = "Healer";
                    break;
                case "2":
                    role_string = "Damage";
                    break;
                default:
                    try
                    {
                        role_string = customGuilds[roleID];
                    }
                    catch (KeyNotFoundException knfe)
                    {
                        role_string = "";
                    }
                    break;
            }
            return role_string;
        }

        /********************************************************************************
        * 
        * Method: GetGuildString
        * 
        * Arguments: string guildID
        * 
        * Return Type: string
        * 
        * Purpose: Determines a Guild type from the enum. 
        * 
        * *******************************************************************************/

        public static string GetGuildString(string guildID)
        {
            string guild_string = "";

            switch (guildID)
            {
                case "475186":
                    guild_string = "Knights of Cydonia";
                    break;
                case "748513":
                    guild_string = "Death and Taxes";
                    break;
                case "154794":
                    guild_string = "I Just Crit My Pants";
                    break;
                case "928126":
                    guild_string = "What Have We Here";
                    break;
                case "513487":
                    guild_string = "Big Dumb Guild";
                    break;
                case "864722":
                    guild_string = "Honestly";
                    break;
                case "185470":
                    guild_string = "Sacred Heart";
                    break;
                case "726518":
                    guild_string = "Dont Click Rez";
                    break;
                case "623818":
                    guild_string = "Less Than Three";
                    break;
                case "019274":
                    guild_string = "Is Bad At This Game";
                    break;
                case "028671":
                    guild_string = "Roll For Initiative";
                    break;
                case "267481":
                    guild_string = "Death and Taxes";
                    break;
                default:
                    try
                    {
                        guild_string = customGuilds[guildID];
                    }
                    catch (KeyNotFoundException knfe)
                    {
                        guild_string = "";
                    }
                    break;
            }
            return guild_string;
        }

        /********************************************************************************
        * 
        * Method: GetRaceString
        * 
        * Arguments: string raceId
        * 
        * Return Type: string
        * 
        * Purpose: Determines a Race type from the enum. 
        * 
        * *******************************************************************************/

        public static string GetRaceString(string raceId)
        {
            switch (raceId)
            {
                case "1":
                    return "Troll";
                case "2":
                    return "Tauren";
                case "3":
                    return "Forsaken";
                case "Troll":
                    return "Troll";
                case "Tauren":
                    return "Tauren";
                case "Forsaken":
                    return "Forsaken";
                default:
                    return "Orc";
            }
        }

        /********************************************************************************
        * 
        * Method: GetClass
        * 
        * Arguments: string class_string
        * 
        * Return Type: string
        * 
        * Purpose: Determines a Class type from the enum. 
        * 
        * *******************************************************************************/

        public static string GetClass(string class_string)
        {
            switch (class_string)
            {
                case "0":
                    return "Warrior";
                case "1":
                    return "Mage";
                case "2":
                    return "Druid";
                case "3":
                    return "Priest";
                case "4":
                    return "Warlock";
                case "5":
                    return "Rogue";
                case "6":
                    return "Paladin";
                case "7":
                    return "Hunter";
                case "Warrior":
                    return "Warrior";
                case "Mage":
                    return "Mage";
                case "Druid":
                    return "Druid";
                case "Priest":
                    return "Priest";
                case "Warlock":
                    return "Warlock";
                case "Rogue":
                    return "Rogue";
                case "Paladin":
                    return "Paladin";
                case "Hunter":
                    return "Hunter";
                default:
                    return "Shaman";
            }
        }

        /********************************************************************************
        * 
        * Method: GetGuildServer
        * 
        * Arguments: Guild g
        * 
        * Return Type: string
        * 
        * Purpose: Returns a Server that's related to a player's Guild. 
        * 
        * *******************************************************************************/

        static string GetGuildServer(Guild g)
        {
            string guild_server = "";
            guild_server = g.Server.ToString();
            return guild_server;
        }

        /********************************************************************************
        * 
        * Method: GetType
        * 
        * Arguments: string guild_type
        * 
        * Return Type: string
        * 
        * Purpose: Returns a Guild Type for a specific Guild. 
        * 
        * *******************************************************************************/

        public static string GetType(string guild_type)
        {      
            switch (guild_type)
            {
                case "0":
                    return "Causal";
                case "1":
                    return "Questing";
                case "2":
                    return "Mythic+";
                case "3":
                    return "Raiding";
                case "4":
                    return "PVP";
                case "Causal":
                    return "Causal";
                case "Questing":
                    return "Questing";
                case "Mythic":
                    return "Mythic+";
                case "Raiding":
                    return "Raiding";
                case "PVP":
                    return "PVP";
                default:
                    return "Causal";

            }
        }

        /********************************************************************************
        * 
        * Method: readGuilds
        * 
        * Arguments: none
        * 
        * Return Type: List<Guild>
        * 
        * Purpose: Reads from the Guilds.txt file, stores them in a List, and returns it. 
        * 
        * *******************************************************************************/

        List<Guild> readGuilds()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-";
            string digits = "0123456789";
            string alphanumeric = alphabet + digits;
            StringBuilder file_data_builder = new StringBuilder();
            bool separated = false;
            using (StreamReader inFile =
            new StreamReader("guilds.txt"))
            {
                while (!inFile.EndOfStream)
                {
                    char ch = (char)inFile.Read();
                    if (!separated && alphanumeric.IndexOf(ch) == -1)
                    {
                        separated = true;
                        file_data_builder.Append('$');
                    }
                    else if (alphanumeric.IndexOf(ch) >= 0)
                    {
                        file_data_builder.Append(ch);
                        separated = false;
                    }
                }
            }
            char[] file_data = file_data_builder.ToString().Trim().ToCharArray();
            StringBuilder id_builder;
            StringBuilder type_builder;        
            StringBuilder name_builder;
            StringBuilder server_builder;
            string id;
            string type;
            string name;
            string server;
            List<Guild> guild_list = new List<Guild>();
            int len = file_data.Length;

            int i = 0;
            while (i < len)
            {
                // Clear the spaces.
                while (i < len && file_data[i] == '$')
                {
                    i++;
                }
                // Read the id.
                id_builder = new StringBuilder();
                while (i < len && file_data[i] != '$')
                {
                    id_builder.Append(file_data[i]);
                    i++;
                }
                id = id_builder.ToString();
                // Clear the spaces.
                while (i < len && file_data[i] == '$')
                {
                    i++;
                }
                // Read the type
                type_builder = new StringBuilder();
                while (i < len && file_data[i] != '$')
                {
                    type_builder.Append(file_data[i]);
                    i++;
                }
                type = type_builder.ToString();
                // Clear the spaces.
                while (i < len && file_data[i] == '$')
                {
                    i++;
                }
                // Read the name
                name_builder = new StringBuilder();
                while (i < len && file_data[i] != '-')
                {
                    if (i < len && file_data[i] != '$')
                    {
                        name_builder.Append(file_data[i]);
                    }
                    else
                    {
                        name_builder.Append(' ');
                    }
                    i++;
                }
                name = name_builder.ToString();
                // Clear the spaces.
                while (i < len && file_data[i] == '$')
                {
                    i++;
                }
                // Read the server
                server_builder = new StringBuilder();
                while (i < len && file_data[i] != '$')
                {
                    if (file_data[i] != '-')
                    {
                        server_builder.Append(file_data[i]);
                    }
                    i++;
                }
                server = server_builder.ToString().Trim();
                Guild G = new Guild(id, type, name, server);
                guild_list.Add(G);
            }        
            return guild_list;
        }

        /********************************************************************************
        * 
        * Method: readPlayers
        * 
        * Arguments: none
        * 
        * Return Type: List<Player>
        * 
        * Purpose: Reads from the Players.txt file, stores them in a List, and returns it. 
        * 
        * *******************************************************************************/

        List<Player> readPlayers()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string alphanumeric = alphabet + digits;
            string file_data_builder = "";
            bool separated = false;
            using (StreamReader inFile = new StreamReader("players.txt"))
            {
                while (!inFile.EndOfStream)
                {
                    char ch = (char)inFile.Read();
                    if (!separated && alphanumeric.IndexOf(ch) == -1)
                    {
                        separated = true;
                        file_data_builder += '$';
                    }
                    else if (alphanumeric.IndexOf(ch) >= 0)
                    {
                        file_data_builder += ch;
                        separated = false;
                    }
                }
            }
            char[] file_data = file_data_builder.ToString().Trim().ToCharArray();
            string id = "";
            string name = "";
            string race = "";
            string class_string = "";
            string role = "";
            string level = "";
            string exp = "";
            string guild_id = "";
            bool reading_id = true;
            bool reading_name = false;
            bool reading_race = false;
            bool reading_class = false;
            bool reading_role = false;
            bool reading_level = false;
            bool reading_exp = false;
            bool reading_guild_id = false;
            List<Player> player_list = new List<Player>();
            string objectBuilder = "";
            foreach (char s in file_data)
            {
                if (s == '$')
                {
                    if (reading_id)
                    {
                        id = objectBuilder.ToString();
                        reading_id = false;
                        reading_name = true;
                    }
                    else if
                    (reading_name)
                    {
                        name = objectBuilder.ToString();
                        reading_name = false;
                        reading_race = true;
                    }
                    else if (reading_race)
                    {
                        race = objectBuilder.ToString();
                        reading_race = false;
                        reading_class = true;
                    }
                    else if (reading_class)
                    {
                        class_string = objectBuilder.ToString();
                        reading_class = false;
                        reading_role = true;
                    }
                    else if (reading_role)
                    {
                        role = objectBuilder.ToString();
                        reading_role = false;
                        reading_level = true;
                    }
                    else if (reading_level)
                    {
                        level = objectBuilder.ToString();
                        reading_level = false;
                        reading_exp = true;
                    }
                    else if (reading_exp)
                    {
                        exp = objectBuilder.ToString();
                        reading_exp = false;
                        reading_guild_id = true;
                    }
                    else if (reading_guild_id)
                    {
                        reading_guild_id = false;
                        guild_id = objectBuilder.ToString();
                        Player P = new Player(id, name, race, class_string, role, level, exp, guild_id);
                        player_list.Add(P);
                        reading_id = true;
                    }
                    objectBuilder = "";
                }
                else
                {
                    objectBuilder += s;
                }
            }
            reading_guild_id = false;
            guild_id = objectBuilder.ToString();
            Player player = new Player(id, name, race, class_string, role, level, exp, guild_id);
            player_list.Add(player);
            reading_id = true;
            return player_list;
        }

        /********************************************************************************
        * 
        * Method: AllPlayersOfClassServerButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: This method handles the first event, option 1. It reads the values in
        *          from two comboboxes, compares it in a LINQ query, and displays the 
        *          result in the ResultsListView.
        * 
        * *******************************************************************************/

        private void AllPlayersOfClassServerButton_Click(object sender, EventArgs e)
        {
            if (ClassComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Class Type to complete this query.");
            }
            else if (SingleServerComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Server Type to complete this query.");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                string class_server = "All " + ClassComboBox.Text + " from " + SingleServerComboBox.Text;
                ResultsListView.Items.Add(class_server);
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var selected_players = from p in player_roster
                                       where (p.GetServer().Equals(SingleServerComboBox.Text) &&
                                       GetClass(p.Class_String).Equals(ClassComboBox.Text))
                                       orderby p.Level ascending
                                       select p;

                foreach (var p in selected_players)
                {
                    ResultsListView.Items.Add(p.ToString());
                }
                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
        }

        /********************************************************************************
        * 
        * Method: PercentageRaceButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: This method handles the event option 2. It gathers it ito
        *          a LINQ query,  and displays the percentage of Races per Server in
        *          the ResultsListView.
        * 
        * *******************************************************************************/

        private void PercentageRaceButton_Click(object sender, EventArgs e)
        {
            
            if (PercentageServerComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Server Type to complete this query.");
            }
            else
            {
                Race race;

                ResultsListView = generateListView(ResultsListView);
                string percentage = PercentageServerComboBox.Text;

                ResultsListView.Items.Add("Percentage of Each Race from " + percentage);
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                int orcs_in_selected_server = (from p in player_roster
                                               where p.GetServer().Equals(PercentageServerComboBox.Text) &&
                                               GetRaceString(p.Race).Equals("Orc")
                                               select p).Count();
                int trolls_in_selected_server = (from p in player_roster
                                                 where p.GetServer().Equals(PercentageServerComboBox.Text) &&
                                                 GetRaceString(p.Race).Equals("Troll")
                                                 select p).Count();
                int taurens_in_selected_server = (from p in player_roster
                                                  where p.GetServer().Equals(PercentageServerComboBox.Text) &&
                                                  GetRaceString(p.Race).Equals("Tauren")
                                                  select p).Count();
                int forsaken_in_selected_server = (from p in player_roster
                                                   where p.GetServer().Equals(PercentageServerComboBox.Text) &&
                                                   GetRaceString(p.Race).Equals("Forsaken")
                                                   select p).Count();

                int selected_server_count = (from p in player_roster
                                             where (p.GetServer().Equals(PercentageServerComboBox.Text))
                                             select p).Count();

                StringBuilder orc_percentage = new StringBuilder(String.Format("{0, -10} {1, -6: 0.00%}", "Orc: ", Convert.ToDecimal((double)orcs_in_selected_server / (double)selected_server_count)));
                StringBuilder troll_percentage = new StringBuilder(String.Format("{0, -10} {1, -6: 0.00%}", "Troll: ", Convert.ToDecimal((double)trolls_in_selected_server / (double)selected_server_count)));
                StringBuilder tauren_percentage = new StringBuilder(String.Format("{0, -10} {1, -6: 0.00%}", "Tauren: ", Convert.ToDecimal((double)taurens_in_selected_server / (double)selected_server_count)));
                StringBuilder forsaken_percentage = new StringBuilder(String.Format("{0, -10} {1, -6: 0.00%}", "Forsaken: ", Convert.ToDecimal((double)forsaken_in_selected_server / (double)selected_server_count)));

                ResultsListView.Items.Add(orc_percentage.ToString());
                ResultsListView.Items.Add(troll_percentage.ToString());
                ResultsListView.Items.Add(tauren_percentage.ToString());
                ResultsListView.Items.Add(forsaken_percentage.ToString());

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
        }

        /********************************************************************************
        * 
        * Method: RoleTypesButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: This method handles the event option 3. It reads the values in
        *          from two comboboxes and two numeric updowns, compares it in a LINQ query,
        *          and displays the result in the ResultsListView. It also makes sure
        *          the updowns have certain limitations.
        * 
        * *******************************************************************************/

        private void RoleTypesButton_Click(object sender, EventArgs e)
        {
            int min = 0, max = 0;
            if (RoleComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Role Type to complete this query.");
            }
            else if (RoleServerComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Server to complete this query.");
            }
            else if (MinNumericUpDown.Value > MaxNumericUpDown.Value)
            {
                max = (int)MinNumericUpDown.Value;
                min = (int)MaxNumericUpDown.Value;
                MinNumericUpDown.Value = 1;
                MaxNumericUpDown.Value = 1;
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Error: Minimun value can not be more than the maximum value.");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                string role_server = "All " + RoleComboBox.Text + " from [" + RoleServerComboBox.Text + "], Levels " + MinNumericUpDown.Value + " to " + MaxNumericUpDown.Value;
                ResultsListView.Items.Add(role_server);
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var selected_players = (from p in player_roster
                                       where (p.GetServer().Equals(RoleServerComboBox.Text) &&
                                       GetRole(p.Role).Equals(RoleComboBox.Text) &&
                                       Convert.ToInt32(p.Level) >= MinNumericUpDown.Value &&
                                       Convert.ToInt32(p.Level) <= MaxNumericUpDown.Value)
                                       orderby p.Level ascending
                                       select p);

                foreach (var p in selected_players)
                {
                    ResultsListView.Items.Add(p.ToString());
                }
                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");


            }
        }

        /********************************************************************************
        * 
        * Method: GuildsSingleTypeButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: This method handles the event option 4. It reads the values in
        *          a single combobox, compares it in a LINQ query, and displays the 
        *          result in the ResultsListView. It is displays all the Guilds in a
        *          specific Server.
        * 
        * *******************************************************************************/

        private void GuildsSingleTypeButton_Click(object sender, EventArgs e)
        {
            if (TypeComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Guild Type to complete this query.");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                string guild_type = TypeComboBox.Text;
                ResultsListView.Items.Add("All " + TypeComboBox.Text + "-Type of Guilds");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var selected_guilds = (from g in guilds_roster
                                       where GetType(g.Type).Equals(TypeComboBox.Text)
                                       group g by g.Server
                                       into g
                                       select new { Server = g.Key, Name = g.ToList() }).Distinct();

                foreach (var g in selected_guilds)
                {
                    var selected_names = from guild_names in selected_guilds
                                         where guild_names.Server.Equals(g.Server)
                                         select guild_names.Name;
                    foreach ( var names in selected_names)
                    {
                        foreach(var n in names)
                        {
                            ResultsListView.Items.Add(String.Format("{0, -15}", n.Server.ToString()));
                            ResultsListView.Items.Add(String.Format("{0, 22}", "<" + n.Name.ToString() + ">"));
                        }
                        
                    }                                           
                }

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
        }

        /********************************************************************************
        * 
        * Method: PlayersWithoutRoleButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: This method handles the event option 5. It compares it in a LINQ query
        *          and displays the result in the ResultsListView. It displays all the
        *          players in the list who can fill a role and are currently part of a
        *          different one.
        * 
        * *******************************************************************************/

        private void PlayersWithoutRoleButton_Click(object sender, EventArgs e)
        {
            if (TankRadioButton.Checked)
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("All Eligible Players Not Fulfilling the Tank Role");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var players_not_in_tank = from p in player_roster
                                          where (GetRole(p.Role) != TankRadioButton.Text) &&
                                          (GetClass(p.Class_String).Equals("Druid") || GetClass(p.Class_String).Equals("Paladin") || GetClass(p.Class_String).Equals("Warrior"))

                                          orderby p.Level ascending
                                          select p;

                foreach (var p in players_not_in_tank)
                {
                    ResultsListView.Items.Add(p.ToString());
                }

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
            else if (HealerRadioButton.Checked)
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("All Eligible Players Not Fulfilling the Healer Role");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var players_not_in_healer = from p in player_roster
                                            where (GetRole(p.Role) != HealerRadioButton.Text &&
                                            (GetClass(p.Class_String).Equals("Druid") || GetClass(p.Class_String).Equals("Paladin") || GetClass(p.Class_String).Equals("Warrior")))
                                            orderby p.Level ascending
                                            select p;

                foreach (var p in players_not_in_healer)
                {
                    ResultsListView.Items.Add(p.ToString());
                }

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
            else if (DamageRadioButton.Checked)
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("All Eligible Players Not Fulfilling the Damage Role");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var players_not_in_damage = from p in player_roster
                                            where (GetRole(p.Role) != DamageRadioButton.Text &&
                                            (GetClass(p.Class_String).Equals("Druid") || GetClass(p.Class_String).Equals("Paladin") || GetClass(p.Class_String).Equals("Warrior")))
                                            orderby p.Level ascending
                                            select p;

                foreach (var p in players_not_in_damage)
                {
                    ResultsListView.Items.Add(p.ToString());
                }

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Role to complete this query.");
            }
        }

        /********************************************************************************
       * 
       * Method: MaxLevelPlayersButton_Click
       * 
       * Arguments: object sender, EventArgs e
       * 
       * Return Type: void
       * 
       * Purpose: This method handles the event option 6. It compares it in a LINQ query
       *          and displays the result in the ResultsListView. It displays all the
       *          max level players average in all guilds.
       * 
       * *******************************************************************************/

        private void MaxLevelPlayersButton_Click(object sender, EventArgs e)
        {
            ResultsListView = generateListView(ResultsListView);
            ResultsListView.Items.Add("Percentage of Max Level Players in All Guilds");
            ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

            var numbers = new List<decimal>();
            decimal sum = numbers.Sum();

            foreach(Guild g in guilds_roster)
            {
                var list_of_max_players = (from p in player_roster
                                           where p.Guild_ID.Equals(g.ID) && p.Level.Equals("60")
                                           select p).Count();
                var total_players_in_guild = (from p in player_roster
                                              where p.Guild_ID.Equals(g.ID)
                                              select p).Count();

                if ( total_players_in_guild > 0 )
                {
                    double percentage = ((double)list_of_max_players / (double)total_players_in_guild);
                    StringBuilder max_level_percentage = new StringBuilder(String.Format("{0, -22}             {1, 8: #,0.00%}", "<" + g.Name + ">", percentage));
                    ResultsListView.Items.Add(max_level_percentage.ToString());
                    ResultsListView.Items.Add("");
                }
                else
                {

                }               
            }

            ResultsListView.Items.Add("");
            ResultsListView.Items.Add("END RESULTS");
            ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
        }

    }

    class Player
    {
        private string id;
        private string name;
        private string race;
        private string class_string;
        private string role;
        private string level;
        private string exp;
        private string guild_id;
        private string server;
        private string guild_type;
        public Player(string id, string name, string race, string class_string, string role, string level, string exp, string guild_id)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.class_string = class_string;
            this.role = role;
            this.level = level;
            this.exp = exp;
            this.guild_id = guild_id;
        }
        public string ID
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Race
        {
            get
            {
                return race;
            }
        }
        public string Class_String
        {
            get
            {
                return class_string;
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
        }
        public string Level
        {
            get
            {
                return level;
            }
        }
        public string Exp
        {
            get
            {
                return exp;
            }
        }
        public string Guild_ID
        {
            get
            {
                return guild_id;
            }
        }
        public int CompareTo(object alpha)
        {
            Player itemObject = (Player)alpha;
            int value = itemObject.Name.CompareTo(this.Name);
            if (value == 1)
                return 1;
            else if (value == -1)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            StringBuilder class_role = new StringBuilder(String.Format("{0, -8} {1, -1} {2, -7}", "(" + Form1.GetClass(class_string), "–", Form1.GetRole(role) + ")"));
            StringBuilder server = new StringBuilder(String.Format("{0, -15}","<" + Form1.GetGuildString(Guild_ID) + ">"));
            StringBuilder stringBuilder = new StringBuilder(String.Format("Name: {0, -13} {1, -15} Race: {2, -20} Level: {3, -2} {4, -15}", name, class_role, Form1.GetRaceString(race), Level, server));

            return stringBuilder.ToString();
        }

        public void SetServer(string server)
        {
            this.server = server;
        }

        public string GetServer()
        {
            return server;
        }

        public void SetGuildType(string guild_type)
        {
            this.guild_type = guild_type;
        }

        public string GetGuildType()
        {
            return guild_type;
        }
    }

    class Guild
    {
        private string id;
        private string type;
        private string name;
        private string server;
        public Guild(string id, string type, string name, string server)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.server = server;
        }
        public string ID
        {
            get
            {
                return id;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Server
        {
            get
            {
                return server;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(String.Format(" ID: {0, -20} Name: {1, -20} Server: {2, -20} Type: {3, -20}", id, name, server, type));

            return stringBuilder.ToString();
        }
    }
}
