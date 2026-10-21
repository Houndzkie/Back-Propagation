using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Back_Propagation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hiddenNodes = ReadInt(hiddenNodesTextBox, "hidden nodes", 1);
                int rows = ReadInt(rowsTextBox, "data rows", 2);
                int epochs = ReadInt(epochsTextBox, "epochs", 1);
                int seed = ReadInt(seedTextBox, "seed", 0);
                double learningRate = ReadDouble(learningRateTextBox, "learning rate");
                double momentum = ReadDouble(momentumTextBox, "momentum");

                if (learningRate < 0.0 || momentum < 0.0)
                    throw new ArgumentException("Learning rate and momentum must not be negative.");

                runButton.Enabled = false;
                Cursor = Cursors.WaitCursor;
                outputTextBox.Clear();
                outputTextBox.AppendText("Generating synthetic data...\r\n");
                Application.DoEvents();

                const int numInput = 4;
                const int numOutput = 3;
                double[][] allData = CodingBackProp.BackPropProgram.MakeAllData(
                    numInput, hiddenNodes, numOutput, rows, seed);

                double[][] trainData;
                double[][] testData;
                CodingBackProp.BackPropProgram.SplitTrainTest(
                    allData, 0.80, seed, out trainData, out testData);

                CodingBackProp.NeuralNetwork network = new CodingBackProp.NeuralNetwork(numInput, hiddenNodes, numOutput);
                double[] weights = network.Train(trainData, epochs, learningRate, momentum);
                double trainAccuracy = network.Accuracy(trainData);
                double testAccuracy = network.Accuracy(testData);

                outputTextBox.AppendText("Back-propagation training complete\r\n");
                outputTextBox.AppendText("Architecture: 4-" + hiddenNodes + "-3\r\n");
                outputTextBox.AppendText("Training rows: " + trainData.Length + "\r\n");
                outputTextBox.AppendText("Test rows: " + testData.Length + "\r\n");
                outputTextBox.AppendText("Training accuracy: " + trainAccuracy.ToString("P2") + "\r\n");
                outputTextBox.AppendText("Test accuracy: " + testAccuracy.ToString("P2") + "\r\n\r\n");
                outputTextBox.AppendText("Final weights and biases:\r\n");

                for (int i = 0; i < weights.Length; ++i)
                    outputTextBox.AppendText("w[" + i + "] = " + weights[i].ToString("F6") + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Unable to run demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                runButton.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private static int ReadInt(TextBox textBox, string name, int minimum)
        {
            int value;
            if (!int.TryParse(textBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value) || value < minimum)
                throw new ArgumentException("Enter a valid " + name + " (minimum " + minimum + ").");
            return value;
        }

        private static double ReadDouble(TextBox textBox, string name)
        {
            double value;
            if (!double.TryParse(textBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out value) || double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentException("Enter a valid " + name + ".");
            return value;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
        }
    }
}
