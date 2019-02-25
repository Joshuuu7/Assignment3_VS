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
    public partial class Form1 : Form
    {
        static Dictionary<string, string> customGuilds = new Dictionary<string, string>();
        List<Player> player_roster = new List<Player>();
        List<Guild> guilds_roster = new List<Guild>();

        public Form1()
        {
            InitializeComponent();
            ResultsListView = generateListView(ResultsListView);             
            ClassComboBox.Items.AddRange(new object [] { "Warrior",
            "Mage",
            "Druid",
            "Priest",
            "Warlock",
            "Rogue",
            "Paladin",
            "Hunter",
            "Shaman" });
            SingleServerComboBox.Items.AddRange(new object [] { "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi" });
            PercentageServerComboBox.Items.AddRange(new object [] { "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi" });
            TypeComboBox.Items.AddRange(new object [] { "0", "1", "2", "3", "4" });
            RoleComboBox.Items.AddRange(new object[] { "Tank", "Healer", "Damage" });
            RoleServerComboBox.Items.AddRange(new object[] { "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi" });
            player_roster = readPlayers();
            player_roster.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Player p in player_roster)
            {
                //Console.WriteLine(p.Name);
            }
            guilds_roster = readGuilds();
            foreach(Guild g in guilds_roster)
            {
                //Console.WriteLine(g.ToString());
            }
            foreach(Player p in player_roster)
            {
                foreach(Guild g in guilds_roster)
                {
                    if (p.Guild_ID.Equals(g.ID))
                    {
                        p.SetServer(g.Server);
                        //Console.WriteLine("Name: {0} Server: {1}", p.Name, p.GetServer());
                    }
                }
            }
            foreach(Player p  in player_roster)
            {
                Console.WriteLine(p.ToString() + " Server: " + p.GetServer());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

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
            listView.Columns[0].Width = 600;
            listView.View = System.Windows.Forms.View.Details;
            return listView;
        }
        public static string GetRole(string roleId)
        {
            string role_string = "";

            switch (roleId)
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
                        role_string = customGuilds[roleId];
                    }
                    catch (KeyNotFoundException knfe)
                    {
                        role_string = "";
                    }
                    break;
            }
            return role_string;
        }

        public static string GetGuildString(string guildId)
        {
            string guild_string = "";

            switch (guildId)
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
                        guild_string = customGuilds[guildId];
                    }
                    catch (KeyNotFoundException knfe)
                    {
                        guild_string = "";
                    }
                    break;
            }
            return guild_string;
        }

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

        static string GetGuildServer(Guild g)
        {
            string guild_server = "";
            guild_server = g.Server.ToString();
            return guild_server;
        }

        List<Guild> readGuilds()
        {

            string alphabet =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-";

            string digits =
            "0123456789";

            string alphanumeric = alphabet + digits;

            StringBuilder file_data_builder = new StringBuilder();

            bool separated =
            false;

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

                    else if (alphanumeric.IndexOf(ch) >=
                    0)

                    {

                        file_data_builder.Append(ch);

                        separated = false;

                    }

                }

            }
            char[] file_data = file_data_builder.ToString().Trim().ToCharArray();

            //Console.WriteLine(file_data_builder.ToString());

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

                while ( i < len && file_data[i] ==
                '$')

                {

                    i++;

                }

                // Read the id.

                id_builder = new StringBuilder();

                while (i < len && file_data[i] !=
                '$')

                {

                    id_builder.Append(file_data[i]);

                    i++;

                }

                id = id_builder.ToString();

                // Clear the spaces.

                while (i < len && file_data[i] ==
                '$')

                {

                    i++;

                }

                // Read the type

                type_builder = new StringBuilder();

                while (i < len && file_data[i] !=
                '$')
                {

                    type_builder.Append(file_data[i]);

                    i++;

                }

                type = type_builder.ToString();

                // Clear the spaces.

                while (i < len && file_data[i] ==
                '$')

                {

                    i++;

                }

                // Read the name

                name_builder = new StringBuilder();

                while (i < len && file_data[i] !=
                '-')

                {

                    if (i < len && file_data[i] !=
                    '$')

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

                while (i < len && file_data[i] ==
                '$')

                {

                    i++;

                }

                // Read the server

                server_builder = new StringBuilder();

                while (i < len && file_data[i] !=
                '$')
                {
                    if(file_data[i] != '-')
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
                        file_data_builder  += '$';
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

        // Option 1
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
                    //Console.WriteLine(p.ToString());
                    ResultsListView.Items.Add(p.ToString());
                }
                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
            }
        }

        // Option 2
        private void PercentageRaceButton_Click(object sender, EventArgs e)
        {
            if (PercentageServerComboBox.Text.Equals(""))
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Server Type to complete this query.");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                string percentage = PercentageServerComboBox.Text;

                ResultsListView.Items.Add("Percentage of Each Race from " + percentage);
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");
                //var orc_count = (from p in player_roster
                //                where GetRaceString(p.Race).Equals("Orc")
                //                select p).Count();

                //var orcs_in_server = (from p in player_roster
                //                     where p.GetServer().Equals(PercentageServerComboBox.Text) &&
                //                     GetRaceString(p.Race).Equals("Orc")
                //                     select p).Count();

                //Console.WriteLine(orc_count.ToString());
                //Console.WriteLine(orcs_in_server.ToString());

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

                StringBuilder orc_percentage = new StringBuilder(String.Format("{0, -10}: {1, 6: 0.00%}", "Orc",Convert.ToDecimal((double)orcs_in_selected_server / (double)selected_server_count)));
                StringBuilder troll_percentage = new StringBuilder(String.Format("{0, -10}: {1, 6: 0.00%}", "Troll ", Convert.ToDecimal((double)trolls_in_selected_server / (double)selected_server_count)));
                StringBuilder tauren_percentage = new StringBuilder(String.Format("{0, -10}: {1, 6: 0.00%}", "Tauren ", Convert.ToDecimal((double)taurens_in_selected_server / (double)selected_server_count)));
                StringBuilder forsaken_percentage = new StringBuilder(String.Format("{0, -10}: {1, 6: 0.00%}", "Forsaken ", Convert.ToDecimal((double)forsaken_in_selected_server / (double)selected_server_count)));

                ResultsListView.Items.Add(orc_percentage.ToString());
                ResultsListView.Items.Add(troll_percentage.ToString());
                ResultsListView.Items.Add(tauren_percentage.ToString());
                ResultsListView.Items.Add(forsaken_percentage.ToString());


                //foreach(int r in race_player_join)
                //{
                //Console.WriteLine("ORCS: " + orcs_in_selected_server.ToString() + " SELECTED SERVER TOTAL: " + selected_server_count );

                //}
                //from p in player_roster
                //where (p.GetServer().Equals(SingleServerComboBox.Text) &&
                //GetClass(p.Class_String).Equals(ClassComboBox.Text))
                //orderby p.Level ascending
                //select p;

                //var selected_server = (from g in guilds_roster
                //                       join p in player_roster on g.ID equals p.Guild_ID
                //                       where g.Server == SingleServerComboBox.Text
                //                       group p by GetRaceString(p.Race) into raceGroup
                //                       select new
                //                       {
                //                           Race = raceGroup.Key ,
                //                           Count = raceGroup.Count()

                //                           //race_count.Add(raceGroup.Key.ToString(), raceGroup.Count()),
                //                       });


                //foreach (var singleServerByRacePercentage in race_player_join)
                //{
                //    StringBuilder race_percentage = new StringBuilder(String.Format("{0, -10}: {1, 6: 0,0}", GetRaceString(singleServerByRacePercentage.Race), Convert.ToDouble(singleServerByRacePercentage.Race.Count())));

                //    ResultsListView.Items.Add(race_percentage.ToString());  
                //}

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");


                //foreach(Guild g in guilds_roster)
                //ResultsListView.Items.Add(g.Server);

                //var selected = (from p in player_roster
                //                from g in guilds_roster
                //                where g.Server.CompareTo(SingleServerComboBox.Text) == 0
                //                where g.ID == GetGuildString(p.Guild_ID)
                //                group p by GetRaceString(p.Race)
                //                ).Distinct();


                //foreach(var singleServerByRacePercentage in selected_server.GroupBy(server => server.Race)
                //    .Select(raceGroup => new {
                //    Race = raceGroup.Key,
                //    Count = raceGroup.Count()
                //    }).OrderBy(x => x.Race)
                //    )

            }
        }

        // Option 3
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
                MinNumericUpDown.Value = 0;
                MaxNumericUpDown.Value = 0;
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Error: Minimun value can not be more than the maximum value.");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                string role_server = "All " + RoleComboBox.Text + " from [" + RoleServerComboBox.Text + "], Levels " + MinNumericUpDown.Value + " to " + MaxNumericUpDown.Value;
                ResultsListView.Items.Add(role_server);
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

                var selected_players = from p in player_roster
                                       where (p.GetServer().Equals(RoleServerComboBox.Text) &&
                                       GetRole(p.Role).Equals(RoleComboBox.Text) &&
                                       Convert.ToInt32(p.Level) >= MinNumericUpDown.Value &&
                                       Convert.ToInt32(p.Level) <= MaxNumericUpDown.Value)
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

        // Option 4
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
                ResultsListView.Items.Add(guild_type);

                var selected_guilds =  from g in guilds_roster
                                       where g.Type.Equals(TypeComboBox.Text)
                                       group g by g.Server;

                foreach (var g in selected_guilds)
                {
                    ResultsListView.Items.Add(g.ToString());
                }

                ResultsListView.Items.Add("");
                ResultsListView.Items.Add("END RESULTS");
                ResultsListView.Items.Add("-------------------------------------------------------------------------------------------");

            }
        }

        // Option 5
        private void PlayersWithoutRoleButton_Click(object sender, EventArgs e)
        {
            if (TankRadioButton.Checked)
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Tank selected.");
            }
            else if (HealerRadioButton.Checked)
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Healer selected.");
            }
            else if (DamageRadioButton.Checked)
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Damage selected.");
            }
            else
            {
                ResultsListView = generateListView(ResultsListView);
                ResultsListView.Items.Add("Please select a Role to complete this query.");
            }
        }

        // Option 6
        private void MaxLevelPlayersButton_Click(object sender, EventArgs e)
        {
            int knights = (from p in player_roster
                           where GetGuildString(p.Guild_ID).Equals("Knights of Cydonia")
                           select p.Level).Count();
            

            StringBuilder knights_max_level_percentage = new StringBuilder(String.Format("{0, -10}: {1, 6: 0,0.00}% Count: {2}", "Knights of Cydonia:  ", (knights/ knights) * 100, knights));

            ResultsListView.Items.Add(knights_max_level_percentage.ToString());
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
            StringBuilder stringBuilder = new StringBuilder(String.Format("Name: {0, -20} {1, -20} Race: {2, -20} Level: {3, -2} {4, -20}", name, "(" + Form1.GetClass(class_string) + " – " + Form1.GetRole(role) + ")", Form1.GetRaceString(race), Level, "<" + Form1.GetGuildString(Guild_ID) + ">"));

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
