using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Data.DataSectionB", Schema = "EDI")]

    public partial class QuestionnairesDataSectionB : BaseEntityQuestionnaire
    {

        public int ChildId { get; set; }
        public byte? EnglishEffectiveUse { get; set; }
        public byte? EnglishListen { get; set; }
        public byte? TellStory { get; set; }
        public byte? ImaginativePlay { get; set; }
        public byte? CommunicateNeeds { get; set; }
        public byte? UnderstandsFirstTry { get; set; }
        public byte? ArticulateClearly { get; set; }
        public byte? HandleBook { get; set; }
        public byte? InterestedBooks { get; set; }
        public byte? InterestedRead { get; set; }
        public byte? TenLetters { get; set; }
        public byte? SoundsToLetters { get; set; }
        public byte? RhymingWords { get; set; }
        public byte? GroupReading { get; set; }
        public byte? ReadSimple { get; set; }
        public byte? ReadComplex { get; set; }
        public byte? ReadSimpleSentence { get; set; }
        public int? YearId { get; set; }
        public virtual Child Child { get; set; }
        public virtual Year Year { get; set; }
    }
}

