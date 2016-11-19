using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=Project1 Type=MainPage)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="MainPage" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="MainPage" SourceLocation="(Assembly=file:///C:/GroupManagement/GroupManagement/GroupManagement/GroupManagement/MainPage.cs StartLineNumber=12 StartCharacterOffset=25 EndLineNumber=12 EndCharacterOffset=33)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=Project1 Type=MainPage)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/GroupManagement/GroupManagement.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/GroupManagement/MainPage.cs" />
    <Alias n="3" Uri="Assembly=$(01904ff3-2658-47bb-a30b-1a89a3912a1b.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="01904ff3-2658-47bb-a30b-1a89a3912a1b.OutputPathUri" Value="file:///C:/GroupManagement/GroupManagement/GroupManagement/GroupManagement/bin/Debug/GroupManagement.exe" />
    <Path Id="VsSolutionUri" Value="file:///C:/GroupManagement/GroupManagement/GroupManagement" />
  </Paths>
</DirectedGraph>
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Profile f2 = new Profile();
            this.Hide();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupEvents f3 = new GroupEvents();
            this.Hide();
            f3.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChronologicalGraph f4 = new ChronologicalGraph();
            this.Hide();
            f4.ShowDialog();

        }
    }
}
