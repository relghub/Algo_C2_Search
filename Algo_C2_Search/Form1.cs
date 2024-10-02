namespace Algo_C2_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EfficiencySearch.Starter(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CharacterAnalysis.Starter(textToAnalyze, textResult);
        }
    }
}
