using FSM.Models;

namespace FSM.Data
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> AllSkills { get; }
        Skill GetSkillById(int skillId);
    }
}
