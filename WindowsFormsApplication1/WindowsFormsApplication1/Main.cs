//#define _DEBUG

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptor;
using usingDLL;

namespace WindowsFormsApplication1
{
	public partial class Main : Form
    {
		const int MAX_ABILITYS		= 3;
		const int MAX_ITMES			= 7;
		const int MAX_RESULTS		= 21;
		const int MAX_BIN_LENGTH	= 6;

		List<AbilityData> abil_Datas = new List<AbilityData>();		// 어빌리티 기본 데이터가 저장
		List<List<AbilityData>> AddedAbils = new List<List<AbilityData>>(MAX_ITMES);        // 선택된 어빌리티들 저장
		/*
		Dictionary<int, AbilityData> abil_Results = new Dictionary<int, AbilityData>();     // 결과 어빌리티 저장
		*/	                           

		// 추가된 아이템 컨트롤 변수
		int addGroupBoxCount = 0;
		List<GroupBox> AddedGroupBox = new List<GroupBox>(MAX_ITMES);

		// 추가시 사용할 변수
		AbilityData[] abil_select = new AbilityData[MAX_ABILITYS];			// 선택된 데이터
		AbilityData[] abil_delete = new AbilityData[MAX_ABILITYS];          // 임시 저장용

		// 결과를 표시할 변수
		List<AbilityData> abil_resultsDump = new List<AbilityData>();
		List<AbilityData> abil_results = new List<AbilityData>();
		List<Label> abil_Labels = new List<Label>();
		int abil_filter_result = 0;

		public Main()
        {
            InitializeComponent();         
        }

		/// <summary>
		/// 각종 변수 초기화
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
        {
			// -- 임시 DLL 파일 생성
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(usingDLLClass.ResolveAssembly);
			// -- 끝

			abil1.Items.Add(" --");
			abil2.Items.Add(" --");
			abil3.Items.Add(" --");
			abil1.SelectedIndex = 0;
			abil2.SelectedIndex = 0;
			abil3.SelectedIndex = 0;

			if (Read_Data())
            {
				AddedGroupBox = AddedBox1.Parent.Controls.OfType<GroupBox>().ToList<GroupBox>();
				AddedGroupBox.Reverse();

				// 초기화 시작
				for (int i = 0; i < MAX_ITMES; i++)
				{
					AddedAbils.Add(new List<AbilityData>(MAX_ABILITYS));
				}

				foreach (AbilityData ad in abil_Datas)
				{
					abil1.Items.Add(ad.Name);
					abil2.Items.Add(ad.Name);
					abil3.Items.Add(ad.Name);
				}

				for(int i = 0; i < abil_delete.Length; i++)
				{
					abil_delete[i] = new AbilityData();
					abil_select[i] = new AbilityData();
				}

				abil_Labels.Add(result_1);
				for(int i = 1; i < MAX_RESULTS; i++)
				{
					Label lb = new Label();
					ResultAbilBox.Controls.Add(lb);
					lb.AutoSize = true;
					lb.Location = new Point(7, (20 + (20 * i)));
					lb.Name = "result_" + (i + 1).ToString();
					lb.Size = new Size(29, 12);
					lb.TabIndex = 0;
					lb.Text = null;
					lb.Visible = false;

					abil_Labels.Add(lb);
				}
				// 초기화 끝
			}
        }


		/// <summary>
		/// ability data 를 설정합니다.
		/// </summary>
		private bool Read_Data()
		{
			Assembly _assembly;
			_assembly = Assembly.GetExecutingAssembly();

			StreamReader sr = new StreamReader(_assembly.GetManifestResourceStream("WindowsFormsApplication1.abilityInfo.dat"));
			//FileStream fs = new FileStream("abilityInfo.dat", FileMode.Open, FileAccess.Read);
			if (sr != null)
			{
				//StreamReader sr = new StreamReader(fs);
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] data = line.Split(',');

					if (data[4] == "") data[4] = "0";
					if (data[5] == "") data[5] = "0";

					AbilityData newAbility
						= new AbilityData(int.Parse(data[0]), data[1], data[2], byte.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));

					abil_Datas.Add(newAbility);
				}

				sr.Close();
				//fs.Close();
				return true;
			}

			return false;
		}


		/// <summary>
		/// 어빌리티 추가
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddAbil_Add_Click(object sender, EventArgs e)
        {
			// 하나도 선택되지 않앗을 경우 초기화
			if (abil1.SelectedIndex == 0 && abil2.SelectedIndex == 0 && abil3.SelectedIndex == 0) return;
			if (addGroupBoxCount >= MAX_ITMES) return;

			for(int i = 0; i < MAX_ITMES; i++)
			{
				if(!AddedGroupBox[i].Visible)
				{
					Added_AddItem(i, abil_select);
					SetAdded_Label(AddedGroupBox[i], abil_select);
					AddReset();
					break;
				}
			}		
		}


		/// <summary>
		/// 어빌리티 초기화
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void AddAblil_Reset_Click(object sender, EventArgs e)
        {
			AddReset();	
		}


		/// <summary>
		/// 추가 선택 초기화
		/// </summary>
		private void AddReset()
		{
			abil1.SelectedIndex = 0;
			abil2.SelectedIndex = 0;
			abil3.SelectedIndex = 0;
		}

		#region 어빌리티 선택
		private void abil1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (abil1.Items.Count > 1)
			{
				if (abil_delete[0].Name != null)
				{
					int count = 0, dummy1 = -1, dummy2 = -1, i = 0;

					foreach (AbilityData ad in abil_Datas)
					{
						if (ad.Name == abil_delete[0].Name) { count = i; }
						else if (ad.Name == abil_delete[1].Name) { dummy1 = i; }
						else if (ad.Name == abil_delete[2].Name) { dummy2 = i; }
						i++;
					}

					if (count > dummy1 && dummy1 != -1) count--;
					if (count > dummy2 && dummy2 != -1) count--;

					abil2.Items.Insert(count + 1, abil_delete[0].Name);
					abil3.Items.Insert(count + 1, abil_delete[0].Name);
				}

				if (abil1.Text == " --")
				{
					abil_select[0].Reset();
					abil_delete[0].Reset();

					Tooptip_Add.SetToolTip(abil1, "");
				}
				else
				{
					foreach (AbilityData ad in abil_Datas)
					{
						if (ad.Name == abil1.Text)
						{
							abil_select[0] = new AbilityData(ad);
							abil_delete[0] = new AbilityData(ad);

							if (abil2.Items.Contains(abil_delete[0].Name)) abil2.Items.RemoveAt(abil2.Items.IndexOf(abil_delete[0].Name));
							if (abil3.Items.Contains(abil_delete[0].Name)) abil3.Items.RemoveAt(abil3.Items.IndexOf(abil_delete[0].Name));

							Tooptip_Add.SetToolTip(abil1, ad.Comment);
							break;
						}
					}
				}
			}
		}

        private void abil2_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (abil2.Items.Count > 1)
			{
				if (abil_delete[1].Name != null)
				{
					int count = 0, dummy1 = -1, dummy2 = -1, i = 0;

					foreach (AbilityData ad in abil_Datas)
					{
						if (ad.Name == abil_delete[1].Name) { count = i; }
						else if (ad.Name == abil_delete[0].Name) { dummy1 = i; }
						else if (ad.Name == abil_delete[2].Name) { dummy2 = i; }
						i++;
					}

					if (count > dummy1 && dummy1 != -1) count--;
					if (count > dummy2 && dummy2 != -1) count--;

					abil1.Items.Insert(count + 1, abil_delete[1].Name);
					abil3.Items.Insert(count + 1, abil_delete[1].Name);
				}

				if (abil2.Text == " --")
				{
					abil_select[1].Reset();
					abil_delete[1].Reset();

					Tooptip_Add.SetToolTip(abil2, "");
				}
				else
				{
					foreach (AbilityData ad in abil_Datas)
					{
						if (ad.Name == abil2.Text)
						{
							abil_select[1] = new AbilityData(ad);
							abil_delete[1] = new AbilityData(ad);

							if (abil1.Items.Contains(abil_delete[1].Name)) abil1.Items.RemoveAt(abil1.Items.IndexOf(abil_delete[1].Name));
							if (abil3.Items.Contains(abil_delete[1].Name)) abil3.Items.RemoveAt(abil3.Items.IndexOf(abil_delete[1].Name));

							Tooptip_Add.SetToolTip(abil2, ad.Comment);
							break;
						}
					}
				}
			}
		}

		private void abil3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (abil3.Items.Count > 1)
			{
				if (abil_delete[2].Name != null)
				{
					int count = 0, dummy1 = -1, dummy2 = -1, i = 0;

					foreach (AbilityData ad in abil_Datas)
					{
						if (ad.Name == abil_delete[2].Name) { count = i; }
						else if (ad.Name == abil_delete[0].Name) { dummy1 = i; }
						else if (ad.Name == abil_delete[1].Name) { dummy2 = i; }
						i++;
					}

					if (count > dummy1 && dummy1 != -1) count--;
					if (count > dummy2 && dummy2 != -1) count--;

					abil1.Items.Insert(count + 1, abil_delete[2].Name);
					abil2.Items.Insert(count + 1, abil_delete[2].Name);
				}

				if (abil3.Text == " --")
				{
					abil_select[2].Reset();
					abil_delete[2].Reset();

					Tooptip_Add.SetToolTip(abil3, "");
				}
				else
				{
					foreach (AbilityData ad in abil_Datas)
					{
						if (ad.Name == abil3.Text)
						{
							abil_select[2] = new AbilityData(ad);
							abil_delete[2] = new AbilityData(ad);

							if (abil1.Items.Contains(abil_delete[2].Name)) abil1.Items.RemoveAt(abil1.Items.IndexOf(abil_delete[2].Name));
							if (abil2.Items.Contains(abil_delete[2].Name)) abil2.Items.RemoveAt(abil2.Items.IndexOf(abil_delete[2].Name));

							Tooptip_Add.SetToolTip(abil3, ad.Comment);
							break;
						}
					}
				}
			}
		}
		#endregion

		/// <summary>
		/// 아이템 삭제 버튼
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Added_DeleteButton_Click(object sender, EventArgs e)
		{
			GroupBox box = (sender as Button).Parent as GroupBox;
			if (box == null) return;

			Added_DeleteItem(box);
		}


		/// <summary>
		/// 아이템 추가
		/// </summary>
		/// <param name="box"></param>
		private void Added_AddItem(int num, AbilityData[] _data)
		{
			List<AbilityData> abils = AddedAbils[num];

			// 데이터 추가
			for (int i = 0; i < _data.Length; i++)
			{
				abils.Add(new AbilityData(_data[i]));
			}	
		}
		private void SetAdded_Label(GroupBox box, AbilityData[] _data)
		{
			List<Label> ls = box.Controls.OfType<Label>().ToList<Label>();
			ls.Reverse();

			for (int i = 0, j = 0; i < ls.Count; j++)
			{
				if (_data[j] != null)
				{
					ls[i].Text = _data[j].Name;
					Tooltip_Added.SetToolTip(ls[i++], _data[j].Comment);
				}
			}

			addGroupBoxCount++;
			box.Visible = true;
		}

		/// <summary>
		/// 아이템 삭제
		/// </summary>
		/// <param name="box"></param>
		private void Added_DeleteItem(GroupBox box)
		{
			hashForFindGroupBox = box.GetHashCode();
			int num = AddedGroupBox.FindIndex(findGroupBox);
			
			List<Label> ls = box.Controls.OfType<Label>().ToList<Label>();
			ls.Reverse();

			// 데이터 삭제 시작
			foreach (Label l in ls)
			{
				l.Text = null;
				Tooltip_Added.SetToolTip(l, "");
			}
			List<AbilityData> abils = AddedAbils[num];
			abils.Clear();
			// 삭제 끝	

			addGroupBoxCount--;
			box.Visible = false;
		}


		/// <summary>
		/// 추가된 아이템 초기화
		/// </summary>
		private void Added_Reset()
		{
			foreach(GroupBox gb in AddedGroupBox)
			{
				Added_DeleteItem(gb);
			}
		}


		#region 합성
		/// <summary>
		/// 특성 합성 버튼
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreateButton_Click(object sender, EventArgs e)
		{
			CreateButton();
		}
		private void CreateButton()
		{
			// 합성 전 초기화
			Result_Reset();
			// 초기화 끝

			for (int i = 0; i < AddedAbils.Count; i++)
			{
				for (int j = 0; j < AddedAbils[i].Count; j++)
				{
					if (AddedAbils[i][j].Name != null) abil_resultsDump.Add(AddedAbils[i][j]);
				}
			}

			Result_Compose();

			if (abil_results.Count > 0)
			{
				// 중복요소 제거
				abil_results = deleteSameValue(abil_results);
				SetResultLabel();
				if (!ResultFilterBox.Enabled) ResultFilterBox.Enabled = true;
			}
		}
		private void SetResultLabel()
		{
			for (int i = 0; i < abil_results.Count; i++)
			{
				string comment = abil_results[i].Comment;

				int key1 = abil_results[i].ComposeID1;
				int key2 = abil_results[i].ComposeID2;

				if (key1 != 0 && key2 != 0)
				{
					AbilityData data1;
					AbilityData data2;

					findAbilityWithID = key1;
					data1 = abil_Datas.Find(findAbilityWithIDResult);

					findAbilityWithID = key2;
					data2 = abil_Datas.Find(findAbilityWithIDResult);

					comment += "\n[" + data1.Name + " x " + data2.Name + "]";
				}

				abil_Labels[i].Text = abil_results[i].Name;
				ToolTip_Result.SetToolTip(abil_Labels[i], comment);
				abil_Labels[i].Visible = true;
			}
		}


		/// <summary>
		/// 특성들을 합성한다.
		/// </summary>
		private void Result_Compose()
		{	
			int count = 0;
			List<AbilityData> temp = abil_resultsDump.ToList<AbilityData>();
			foreach(AbilityData ad in abil_resultsDump)
			{
				findComposeAbility = ad.ID;
				if (!temp.Contains(ad)) continue;

				List<AbilityData> find = abil_Datas.FindAll(findComposeResult);
				if (find.Count == 0)
				{
					// 현재 특성에 합성에 쓰이지 않을 경우, 결과에 추가
					abil_results.Add(ad);
				}
				else
				{
					List<AbilityData> temp2 = new List<AbilityData>();
					foreach (AbilityData f in find)
					{
						if (f.ComposeID1 == ad.ID) findAbilityWithID = f.ComposeID2;
						else findAbilityWithID = f.ComposeID1;

						AbilityData findAnother = temp.Find(findAbilityWithIDResult);
						if (findAnother == null)
						{
							// 합성에 사용되지만 다른 재료가 없을 경우, 결과에 추가
							if(!temp2.Contains(ad)) temp2.Add(ad);
						}
						else
						{
							// 합성에 사용되고, 재료도 존재한다.
							temp.Remove(findAnother);
							abil_results.Add(f);
							if (temp2.Contains(ad)) temp2.Remove(ad);
							count++;
						}
					}

					for(int i =0; i< temp2.Count; i++)
					{
						abil_results.Add(temp2[i]);
					}
				}
			}

			if (count != 0)
			{
				abil_resultsDump = abil_results.ToList<AbilityData>();
				abil_results.Clear();
				Result_Compose();
			}
		}


		/// <summary>
		/// 결과 리셋
		/// </summary>
		private void Result_Reset()
		{
			abil_results.Clear();
			abil_resultsDump.Clear();
			foreach (Label lb in abil_Labels) { lb.Visible = false; lb.Enabled = true; }
			if(ResultFilterBox != null)
			{
				ResultFilterBox.Enabled = false;
				ResultFilterBox.Controls.OfType<RadioButton>().ToList<RadioButton>()[5].Checked = true;
			}
			
		}

		/// <summary>
		/// 리스트에서 중복된 값을 삭제
		/// </summary>
		/// <param name="_data"></param>
		/// <returns></returns>
		private List<AbilityData> deleteSameValue(List<AbilityData> _data)
		{
			List<AbilityData> value = new List<AbilityData>();

			foreach (AbilityData ad in _data)
			{
				if (findSameValueInList(value, ad.ID)) continue;
				value.Add(ad);
			}

			return value;
		}


		/// <summary>
		/// 해당 리스트에서 ID를 이용해 같은 값이 존재하는지 찾습니다.
		/// </summary>
		/// <param name="_data"></param>
		/// <param name="_id"></param>
		/// <returns></returns>
		private bool findSameValueInList(List<AbilityData> _data, int _id)
		{
			findAbilityWithID = _id;
			return _data.Exists(findAbilityWithIDResult);
		}


		/// <summary>
		/// 모든걸 초기화 한다.
		/// </summary>
		private void Result_AllResetButton_Click(object sender, EventArgs e)
		{
			ResetAll();
		}
		private void ResetAll()
		{
			AddReset();
			Added_Reset();
			Result_Reset();
		}


		/// <summary>
		/// 아이템 타입 선택
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Result_CheckedChanged(object sender, EventArgs e)
		{
			if (abil_results.Count == 0) return;
			RadioButton s = (sender as RadioButton);
			if (!s.Checked) return;


			/*
				UI의 TAG에 정보가 저장되어 있다. (byte)
				32	- 재료
				16	- 공격
				8	- 회복
				4	- 무기
				2	- 방어
				1	- 장신구
			*/
			byte binData = 0;
			if(byte.TryParse(s.Tag.ToString(), out binData))
			{
				string binCode = Convert.ToString(binData, 2);
				//(sender as RadioButton).Text = binCode.ToString();
				Result_EnableItem((binCode.Length - 6) * -1);
			}
		}

		/// <summary>
		/// 결과값 중 선택된 필터에 맞는 특성만 활성화 시킨다.
		/// </summary>
		/// <param name="num"></param>
		private void Result_EnableItem(int num)
		{
			abil_filter_result = num;
			for(int i = 0; i < abil_results.Count; i++)
			{
				abil_Labels[i].Enabled = true;	
				string binCode = Convert.ToString(abil_results[i].Code, 2);

#if _DEBUG
				abil_Labels[i].Text = binCode.ToString();
				ResultFilterBox.Text = num.ToString();
#endif

				if (binCode[num] != '1') abil_Labels[i].Enabled = false;
			}
		}
		#endregion


		#region
		/// <summary>
		/// 저장
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// 저장 다이얼로그 설정 및 출력
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.Filter	= "save file(*.sav)|*.sav";
			saveDialog.Title	= "저장하기";
			saveDialog.InitialDirectory = System.Environment.CurrentDirectory;
			saveDialog.ShowDialog();

			if(saveDialog.FileName != "")
			{
				FileStream fs = (FileStream)saveDialog.OpenFile();

				// 여기서 세이브파일 구성
				string byte_buffer_string = "START,";

				// 선택 특성
				byte_buffer_string += "ADDED,";
				foreach(List<AbilityData> lad in AddedAbils)
				{
					foreach(AbilityData ad in lad)
					{
						byte_buffer_string += ad.ID.ToString();
						byte_buffer_string += ",";
					}
				}

				// 결과
				byte_buffer_string += "RESULT,";
				foreach(AbilityData ad in abil_results)
				{
					byte_buffer_string += ad.ID.ToString();
					byte_buffer_string += ",";
				}

				byte_buffer_string += "FILTER," + abil_filter_result.ToString() + ",END";
				byte_buffer_string = CryptorClass.EncryptUseDES(byte_buffer_string);
				// 구성 끝

				// 저장 시작
				int byte_bufferCount = Encoding.Default.GetByteCount(byte_buffer_string);
				byte[] bData = new byte[byte_bufferCount];

				bData = Encoding.Default.GetBytes(byte_buffer_string);
				fs.Seek(0, SeekOrigin.Begin);
				fs.Write(bData, 0, byte_bufferCount);
				fs.Close();
			}
		}

		/// <summary>
		/// 불러오기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openDialog = new OpenFileDialog();
			openDialog.Filter = "save file(*.sav)|*.sav";
			openDialog.Title = "저장하기";
			openDialog.InitialDirectory = System.Environment.CurrentDirectory;
			openDialog.ShowDialog();

			if(openDialog.FileName != "")
			{
				FileStream fs = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
				if (fs != null)
				{
					FileInfo fInfo = new FileInfo(openDialog.FileName);

					int byte_bufferCount = Convert.ToInt32(fInfo.Length);
					byte[] bData = new byte[byte_bufferCount];

					fs.Seek(0, SeekOrigin.Begin);
					fs.Read(bData, 0, byte_bufferCount);

					string byte_buffer_string = Encoding.Default.GetString(bData, 0, bData.Length);
					byte_buffer_string = CryptorClass.DecryptUseDES(byte_buffer_string);
					string[] contents = byte_buffer_string.Split(',');

					string first = contents.First<string>();
					string end = contents.Last<string>();

					// 오류 체크
					if (!first.Equals("START") || !end.Equals("END"))
					{
						if (MessageBox.Show("세이브 파일이 잘못되었습니다", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
						{
							fs.Close();
							return;
						}
					}

					// 초기화
					ResetAll();
					// 파일 읽기
					int type = 0, groupBoxCount = 0, labelCount = 0;
					for (int i = 0; i < contents.Length; i++)
					{
						if (contents[i] == "START" || contents[i] == "END") continue;

						if (contents[i] == "ADDED") { type = 1; continue; }
						else if (contents[i] == "RESULT") { type = 2; continue; }
						else if (contents[i] == "FILTER") { type = 3; continue; }

						switch (type)
						{
							case 1:
								{
									findAbilityWithID = int.Parse(contents[i]);
									AbilityData ad = abil_Datas.Find(findAbilityWithIDResult);

									if (ad != null)
									{
										AddedAbils[groupBoxCount].Add(new AbilityData(ad));
									}
									else
									{
										AddedAbils[groupBoxCount].Add(new AbilityData());
									}
									labelCount++;
									if (labelCount == 3) { groupBoxCount++; labelCount = 0; }
								}
								break;
							case 2:
								{
									findAbilityWithID = int.Parse(contents[i]);
									AbilityData ad = abil_Datas.Find(findAbilityWithIDResult);

									if (ad != null)
									{
										abil_results.Add(new AbilityData(ad));
									}
								}
								break;
							case 3:
								{
									if (!int.TryParse(contents[i], out abil_filter_result))
									{
										if (MessageBox.Show("세이브 파일이 잘못되었습니다", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
										{
											fs.Close();
											return;
										}
									}
								}
								break;
							default:
								{
									if (MessageBox.Show("세이브 파일이 잘못되었습니다", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
									{
										fs.Close();
										return;
									}
								}
								break;
						}
					}

					for (int i = 0; i < groupBoxCount; i++)
					{
						SetAdded_Label(AddedGroupBox[i], AddedAbils[i].ToArray());
					}
					SetResultLabel();
					ResultFilterBox.Enabled = true;
					ResultFilterBox.Controls.OfType<RadioButton>().ToList().Reverse<RadioButton>().ToList()[abil_filter_result].Checked = true;
					Result_EnableItem(abil_filter_result);
					
					fs.Close();
				}
			}
		}


		/// <summary>
		/// 종료
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion


		#region 
		// 해쉬코드를 이용해 그룹박스를 검색합니다.
		static int hashForFindGroupBox = 0;
		private static bool findGroupBox(GroupBox box)
		{
			if (hashForFindGroupBox == box.GetHashCode()) return true;
			else return false;
		}
		// 해당 ID를 재료로 하는 특성이 있는지 검색합니다.
		private static int findComposeAbility = 0;
		private static bool findComposeResult(AbilityData _data)
		{
			if (_data.ComposeID1 == findComposeAbility) return true;
			else if (_data.ComposeID2 == findComposeAbility) return true;
			else return false;
		}
		// 리스트에서 특정 ID를 가진 특성을 검색합니다.
		private static int findAbilityWithID = 0;
		private static bool findAbilityWithIDResult(AbilityData _data)
		{
			return _data.ID == findAbilityWithID;
		}
		#endregion

		private void fontDialog1_Apply(object sender, EventArgs e)
		{

		}

		private void AddedBox3_Enter(object sender, EventArgs e)
		{

		}
	}
}
