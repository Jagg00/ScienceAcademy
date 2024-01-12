using ScienceAcademy.Business.Interfaces;
using ScienceAcademy.Data.Repositories;

namespace ScienceAcademy.UI
{
    public partial class frmMain : Form
    {
        private readonly IAwardBusiness awardBusiness;
        private readonly IMemberBusiness memberBusiness;
        private readonly IUniversityBusiness universityBusiness;

        private readonly string award = "Award";
        private readonly string member = "Member";
        private readonly string university = "University";


        public frmMain(IAwardBusiness awardBusiness, IMemberBusiness memberBusiness, IUniversityBusiness universityBusiness)
        {
            InitializeComponent();

            this.awardBusiness = awardBusiness;
            this.memberBusiness = memberBusiness;
            this.universityBusiness = universityBusiness;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvAwards.DataSource = awardBusiness.GetAllAsync().Result;
            dgvMembers.DataSource = memberBusiness.GetAllAsync().Result;
            dgvUniversities.DataSource = universityBusiness.GetAllAsync().Result;

            cmbEntitySelect.Items.Add(award);
            cmbEntitySelect.Items.Add(member);
            cmbEntitySelect.Items.Add(university);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = new Guid(txtDeleteId.Text.Trim());

            switch (cmbEntitySelect.Text)
            {
                case "Award":
                    awardBusiness.AddAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI"));
                    break;
                case "Member":
                    awardBusiness.AddAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI"));
                    break;
                case "University":
                    awardBusiness.AddAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI"));
                    break;
                default:
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (cmbEntitySelect.Text)
            {
                case "Award":
                    var dto = awardBusiness.UpdateAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI")).Result;
                    break;
                case "Member":
                    var dto2 = awardBusiness.UpdateAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI")).Result;
                    break;
                case "University":
                    var dto3 = awardBusiness.UpdateAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI")).Result;
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = new Guid(txtDeleteId.Text.Trim());

            switch (cmbEntitySelect.Text)
            {
                case "Award":
                    awardBusiness.DeleteAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI"));
                    break;
                case "Member":
                    awardBusiness.DeleteAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI"));
                    break;
                case "University":
                    awardBusiness.DeleteAsync(new Data.Dtos.AwardDto(DateTime.Now, "UI"));
                    break;
                default:
                    break;
            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            var id = new Guid(txtId.Text.Trim());

            switch (cmbEntitySelect.Text)
            {
                case "Award":
                    awardBusiness.GetByIdAsync(id);
                    break;
                case "Member":
                    memberBusiness.GetByIdAsync(id);
                    break;
                case "University":
                    universityBusiness.GetByIdAsync(id);
                    break;
                default:
                    break;
            }
        }
    }
}
