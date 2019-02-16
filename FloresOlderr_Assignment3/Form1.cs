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

            player_roster = readPlayers();
            foreach(Player p in player_roster)
            {
                Console.WriteLine(p.Name);
            }
            guilds_roster = readGuilds();
            foreach(Guild g in guilds_roster)
            {
                Console.WriteLine(g.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private ListView generateListView(ListView results)
        {
            this.ResultsListView.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            this.ResultsListView.Columns.Add(header);
            // Then
            this.ResultsListView.Scrollable = true;
            for (int i = 0; i < this.ResultsListView.Columns.Count - 1; i++)
                this.ResultsListView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.ResultsListView.Columns[this.ResultsListView.Columns.Count - 1].Width = -2;
            this.ResultsListView.Columns[0].Width = 800;
            this.ResultsListView.View = System.Windows.Forms.View.Details;
            results = this.ResultsListView;
            return results;
        }

        private string getRaceString(string raceId)
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

        List<Guild> readGuilds()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
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
            Console.WriteLine(file_data_builder.ToString());
            char[] file_data = file_data_builder.ToString().Trim().ToCharArray();
            string id = "";
            string type = "";
            string name = "";
            string server = "";
            bool reading_id = true;
            bool reading_type = false;
            bool reading_name = false;
            bool reading_server = false;
            List<Guild> guild_list = new List<Guild>();
            StringBuilder objectBuilder = new StringBuilder();
            foreach (char s in file_data)
            {
                if (s == '$')
                {
                    if (reading_id)
                    {
                        id = objectBuilder.ToString();
                        reading_id = false;
                        reading_type = true;
                    }
                    else if (reading_type)
                    {
                        type = objectBuilder.ToString();
                        reading_type = false;
                        reading_name = true;
                    }
                    else if (reading_name)
                    {
                        name = objectBuilder.ToString();
                        reading_name = false;
                        reading_server = true;
                    }
                    else if (reading_server)
                    {
                        server = objectBuilder.ToString();
                        Guild g = new Guild(id, type, name, server);
                        guild_list.Add(g);
                        reading_server = false;
                        reading_id = true;
                    }
                    objectBuilder = new StringBuilder();
                }
                else
                {
                    objectBuilder.Append(s);
                }
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
                ResultsListView.Items.Add("Hoorayyyy");
            }
        }

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
                ResultsListView.Items.Add("Percentage clicked.");
            }
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
            StringBuilder stringBuilder = new StringBuilder(String.Format("{0, -15} {1, -20} {2, 2}", name, Form1.GetClass(class_string), Level, 60));

            return stringBuilder.ToString();
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
    }
}
