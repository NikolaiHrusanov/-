using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratory_of_profesor_Kondenstain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // string a = "";
        private void Btn_Add_Ingreadance_Click(object sender, EventArgs e)
        {
            string text = Txb_enter_Ingredients.Text.Trim();

            if (!string.IsNullOrEmpty(text))
            {
                listBox1.Items.Add(text.ToLower());
                Txb_enter_Ingredients.Clear();
                Txb_enter_Ingredients.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_boil_a_potion_Click(object sender, EventArgs e)
        {
            bool hasCatHair = false;
            bool hasLiquidNitrogen = false;
            bool hasStrawberry = false;
            bool hasSugar = false;
            bool hasBattery = false;
            bool hasWater = false;
            bool hasChili = false;
            bool hasUnicornTear = false;
            bool hasSpiderLeg = false;
            bool hasPumpkin = false;
            bool hasMoonDust = false;
            bool hasRottenFlesh = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string ingredient = listBox1.Items[i].ToString();

                if (ingredient == "котешка козина")   hasCatHair = true;
                if (ingredient == "течен азот")       hasLiquidNitrogen = true;
                if (ingredient == "ягода")            hasStrawberry = true;
                if (ingredient == "захар")            hasSugar = true;
                if (ingredient == "батерия")          hasBattery = true;
                if (ingredient == "вода")             hasWater = true;
                if (ingredient == "люта чушка")       hasChili = true;
                if (ingredient == "сълза от еднорог") hasUnicornTear = true;
                if (ingredient == "крак от паяк")     hasSpiderLeg = true;
                if (ingredient == "тиква")            hasPumpkin = true;
                if (ingredient == "лунен прах")       hasMoonDust = true;
                if (ingredient == "гнило месо")       hasRottenFlesh = true;
            }

            string result = "";

            if (hasCatHair && hasLiquidNitrogen) //котешка козина" & течен азот
                result = "Създаде невидимост за 10 минути!";

            else if (hasStrawberry && hasSugar) //ягода & захар
                result = "Създаде вкусно сладко!";

            else if (hasBattery && hasWater)   //батерия & вода
                result = "Създаде експлозивен серум… стой далеч!";

            else if (hasChili && hasUnicornTear)  //люта чушка & сълза от еднорог
                result = "Създаде огнен дъх – като дракон!";

            else if (hasSpiderLeg && hasPumpkin)   //крак от паяк & тиква
                result = "Създаде прокълнат фенер… Хелоуин идва!";

            else if (hasMoonDust && hasWater)     //лунен прах & вода
                result = "Създаде елексир на сънищата – сладки сънища!";

            else if (hasStrawberry && hasChili)    //ягода & люти чушки
                result = "Създаде сладко с пламък – пикантна наслада!";

            else if (hasRottenFlesh && hasPumpkin) //гнило месо & тиква
                result = "Създаде зомби тиквеняк – бягай!";

            else    //може би просто си направи супа
                result = "Получената отвара бълбука, но нищо интересно не се случва.";

            lbl_result.Text = result;
        }

    }
}
