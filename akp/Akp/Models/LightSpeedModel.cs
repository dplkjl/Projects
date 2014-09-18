using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace Akp.Models
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  public partial class AukatiAssessment : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _provider;
    private int _assessmentId;
    private System.DateTime _enrolmentDate;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _programmeStatus;
    private System.Nullable<int> _age;
    private System.Nullable<int> _startSmokingAge;
    private System.Nullable<int> _timeoffSmoking;
    [ValidateLength(0, 50)]
    private string _pregnancyStatus;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _numberofTailorMades;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _amountofLooseTobacco;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _smokingathome;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _smokinginCar;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _householdNumber;
    [ValidateLength(0, 75)]
    private string _under5;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _regularSmokers;
    private string _comments;
    [ValidateLength(0, 75)]
    private string _heardaboutService;
    [ValidateLength(0, 75)]
    private string _primaryMotivationtoQuit;
    private bool _brupropion;
    [ValidateLength(0, 75)]
    private string _firstCigarette;
    private bool _nortryptyline;
    private System.Nullable<short> _referralId;
    [ValidateLength(0, 75)]
    private string _smokelyzer;
    private System.Nullable<System.DateTime> _tqDate;
    private bool _varenicline;
    private System.Nullable<System.DateTime> _exitDate;
    [ValidateLength(0, 75)]
    private string _exitType;
    private int _clientId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Provider entity attribute.</summary>
    public const string ProviderField = "Provider";
    /// <summary>Identifies the AssessmentId entity attribute.</summary>
    public const string AssessmentIdField = "AssessmentId";
    /// <summary>Identifies the EnrolmentDate entity attribute.</summary>
    public const string EnrolmentDateField = "EnrolmentDate";
    /// <summary>Identifies the ProgrammeStatus entity attribute.</summary>
    public const string ProgrammeStatusField = "ProgrammeStatus";
    /// <summary>Identifies the Age entity attribute.</summary>
    public const string AgeField = "Age";
    /// <summary>Identifies the StartSmokingAge entity attribute.</summary>
    public const string StartSmokingAgeField = "StartSmokingAge";
    /// <summary>Identifies the TimeoffSmoking entity attribute.</summary>
    public const string TimeoffSmokingField = "TimeoffSmoking";
    /// <summary>Identifies the PregnancyStatus entity attribute.</summary>
    public const string PregnancyStatusField = "PregnancyStatus";
    /// <summary>Identifies the NumberofTailorMades entity attribute.</summary>
    public const string NumberofTailorMadesField = "NumberofTailorMades";
    /// <summary>Identifies the AmountofLooseTobacco entity attribute.</summary>
    public const string AmountofLooseTobaccoField = "AmountofLooseTobacco";
    /// <summary>Identifies the Smokingathome entity attribute.</summary>
    public const string SmokingathomeField = "Smokingathome";
    /// <summary>Identifies the SmokinginCar entity attribute.</summary>
    public const string SmokinginCarField = "SmokinginCar";
    /// <summary>Identifies the HouseholdNumber entity attribute.</summary>
    public const string HouseholdNumberField = "HouseholdNumber";
    /// <summary>Identifies the Under5 entity attribute.</summary>
    public const string Under5Field = "Under5";
    /// <summary>Identifies the RegularSmokers entity attribute.</summary>
    public const string RegularSmokersField = "RegularSmokers";
    /// <summary>Identifies the Comments entity attribute.</summary>
    public const string CommentsField = "Comments";
    /// <summary>Identifies the HeardaboutService entity attribute.</summary>
    public const string HeardaboutServiceField = "HeardaboutService";
    /// <summary>Identifies the PrimaryMotivationtoQuit entity attribute.</summary>
    public const string PrimaryMotivationtoQuitField = "PrimaryMotivationtoQuit";
    /// <summary>Identifies the Brupropion entity attribute.</summary>
    public const string BrupropionField = "Brupropion";
    /// <summary>Identifies the FirstCigarette entity attribute.</summary>
    public const string FirstCigaretteField = "FirstCigarette";
    /// <summary>Identifies the Nortryptyline entity attribute.</summary>
    public const string NortryptylineField = "Nortryptyline";
    /// <summary>Identifies the ReferralId entity attribute.</summary>
    public const string ReferralIdField = "ReferralId";
    /// <summary>Identifies the Smokelyzer entity attribute.</summary>
    public const string SmokelyzerField = "Smokelyzer";
    /// <summary>Identifies the TqDate entity attribute.</summary>
    public const string TqDateField = "TqDate";
    /// <summary>Identifies the Varenicline entity attribute.</summary>
    public const string VareniclineField = "Varenicline";
    /// <summary>Identifies the ExitDate entity attribute.</summary>
    public const string ExitDateField = "ExitDate";
    /// <summary>Identifies the ExitType entity attribute.</summary>
    public const string ExitTypeField = "ExitType";
    /// <summary>Identifies the ClientId entity attribute.</summary>
    public const string ClientIdField = "ClientId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("AukatiAssessments")]
    private readonly EntityHolder<Client> _client = new EntityHolder<Client>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Client Client
    {
      get { return Get(_client); }
      set { Set(_client, value); }
    }


    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Provider
    {
      get { return Get(ref _provider, "Provider"); }
      set { Set(ref _provider, value, "Provider"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int AssessmentId
    {
      get { return Get(ref _assessmentId, "AssessmentId"); }
      set { Set(ref _assessmentId, value, "AssessmentId"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime EnrolmentDate
    {
      get { return Get(ref _enrolmentDate, "EnrolmentDate"); }
      set { Set(ref _enrolmentDate, value, "EnrolmentDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ProgrammeStatus
    {
      get { return Get(ref _programmeStatus, "ProgrammeStatus"); }
      set { Set(ref _programmeStatus, value, "ProgrammeStatus"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> Age
    {
      get { return Get(ref _age, "Age"); }
      set { Set(ref _age, value, "Age"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> StartSmokingAge
    {
      get { return Get(ref _startSmokingAge, "StartSmokingAge"); }
      set { Set(ref _startSmokingAge, value, "StartSmokingAge"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> TimeoffSmoking
    {
      get { return Get(ref _timeoffSmoking, "TimeoffSmoking"); }
      set { Set(ref _timeoffSmoking, value, "TimeoffSmoking"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string PregnancyStatus
    {
      get { return Get(ref _pregnancyStatus, "PregnancyStatus"); }
      set { Set(ref _pregnancyStatus, value, "PregnancyStatus"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string NumberofTailorMades
    {
      get { return Get(ref _numberofTailorMades, "NumberofTailorMades"); }
      set { Set(ref _numberofTailorMades, value, "NumberofTailorMades"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AmountofLooseTobacco
    {
      get { return Get(ref _amountofLooseTobacco, "AmountofLooseTobacco"); }
      set { Set(ref _amountofLooseTobacco, value, "AmountofLooseTobacco"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Smokingathome
    {
      get { return Get(ref _smokingathome, "Smokingathome"); }
      set { Set(ref _smokingathome, value, "Smokingathome"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string SmokinginCar
    {
      get { return Get(ref _smokinginCar, "SmokinginCar"); }
      set { Set(ref _smokinginCar, value, "SmokinginCar"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string HouseholdNumber
    {
      get { return Get(ref _householdNumber, "HouseholdNumber"); }
      set { Set(ref _householdNumber, value, "HouseholdNumber"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Under5
    {
      get { return Get(ref _under5, "Under5"); }
      set { Set(ref _under5, value, "Under5"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string RegularSmokers
    {
      get { return Get(ref _regularSmokers, "RegularSmokers"); }
      set { Set(ref _regularSmokers, value, "RegularSmokers"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Comments
    {
      get { return Get(ref _comments, "Comments"); }
      set { Set(ref _comments, value, "Comments"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string HeardaboutService
    {
      get { return Get(ref _heardaboutService, "HeardaboutService"); }
      set { Set(ref _heardaboutService, value, "HeardaboutService"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string PrimaryMotivationtoQuit
    {
      get { return Get(ref _primaryMotivationtoQuit, "PrimaryMotivationtoQuit"); }
      set { Set(ref _primaryMotivationtoQuit, value, "PrimaryMotivationtoQuit"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public bool Brupropion
    {
      get { return Get(ref _brupropion, "Brupropion"); }
      set { Set(ref _brupropion, value, "Brupropion"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string FirstCigarette
    {
      get { return Get(ref _firstCigarette, "FirstCigarette"); }
      set { Set(ref _firstCigarette, value, "FirstCigarette"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public bool Nortryptyline
    {
      get { return Get(ref _nortryptyline, "Nortryptyline"); }
      set { Set(ref _nortryptyline, value, "Nortryptyline"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<short> ReferralId
    {
      get { return Get(ref _referralId, "ReferralId"); }
      set { Set(ref _referralId, value, "ReferralId"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Smokelyzer
    {
      get { return Get(ref _smokelyzer, "Smokelyzer"); }
      set { Set(ref _smokelyzer, value, "Smokelyzer"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> TqDate
    {
      get { return Get(ref _tqDate, "TqDate"); }
      set { Set(ref _tqDate, value, "TqDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public bool Varenicline
    {
      get { return Get(ref _varenicline, "Varenicline"); }
      set { Set(ref _varenicline, value, "Varenicline"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> ExitDate
    {
      get { return Get(ref _exitDate, "ExitDate"); }
      set { Set(ref _exitDate, value, "ExitDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ExitType
    {
      get { return Get(ref _exitType, "ExitType"); }
      set { Set(ref _exitType, value, "ExitType"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Client" /> property.</summary>
    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int ClientId
    {
      get { return Get(ref _clientId, "ClientId"); }
      set { Set(ref _clientId, value, "ClientId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  public partial class ClientsIwi : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _provider;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _iwi;
    private int _clientId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Provider entity attribute.</summary>
    public const string ProviderField = "Provider";
    /// <summary>Identifies the Iwi entity attribute.</summary>
    public const string IwiField = "Iwi";
    /// <summary>Identifies the ClientId entity attribute.</summary>
    public const string ClientIdField = "ClientId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("ClientsIwis")]
    private readonly EntityHolder<Client> _client = new EntityHolder<Client>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Client Client
    {
      get { return Get(_client); }
      set { Set(_client, value); }
    }


    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Provider
    {
      get { return Get(ref _provider, "Provider"); }
      set { Set(ref _provider, value, "Provider"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Iwi
    {
      get { return Get(ref _iwi, "Iwi"); }
      set { Set(ref _iwi, value, "Iwi"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Client" /> property.</summary>
    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int ClientId
    {
      get { return Get(ref _clientId, "ClientId"); }
      set { Set(ref _clientId, value, "ClientId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  public partial class AukatiFollowup : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _provider;
    private double _clientId;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _followUpType;
    private System.DateTime _followUpDate;
    private int _assessmentId;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _contactType;
    private string _reasonWhyNot;
    [ValidateLength(0, 75)]
    private string _quitStatus;
    private string _reasonForStarting;
    [ValidateLength(0, 75)]
    private string _smokingAtHome;
    [ValidateLength(0, 75)]
    private string _smokingInCar;
    private string _generalComments;
    [ValidateLength(0, 75)]
    private string _reasonNotContacted;
    [ValidateLength(0, 6)]
    private string _staffId;
    [ValidateLength(0, 75)]
    private string _smokelyzer;
    private int _idId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Provider entity attribute.</summary>
    public const string ProviderField = "Provider";
    /// <summary>Identifies the ClientId entity attribute.</summary>
    public const string ClientIdField = "ClientId";
    /// <summary>Identifies the FollowUpType entity attribute.</summary>
    public const string FollowUpTypeField = "FollowUpType";
    /// <summary>Identifies the FollowUpDate entity attribute.</summary>
    public const string FollowUpDateField = "FollowUpDate";
    /// <summary>Identifies the AssessmentId entity attribute.</summary>
    public const string AssessmentIdField = "AssessmentId";
    /// <summary>Identifies the ContactType entity attribute.</summary>
    public const string ContactTypeField = "ContactType";
    /// <summary>Identifies the ReasonWhyNot entity attribute.</summary>
    public const string ReasonWhyNotField = "ReasonWhyNot";
    /// <summary>Identifies the QuitStatus entity attribute.</summary>
    public const string QuitStatusField = "QuitStatus";
    /// <summary>Identifies the ReasonForStarting entity attribute.</summary>
    public const string ReasonForStartingField = "ReasonForStarting";
    /// <summary>Identifies the SmokingAtHome entity attribute.</summary>
    public const string SmokingAtHomeField = "SmokingAtHome";
    /// <summary>Identifies the SmokingInCar entity attribute.</summary>
    public const string SmokingInCarField = "SmokingInCar";
    /// <summary>Identifies the GeneralComments entity attribute.</summary>
    public const string GeneralCommentsField = "GeneralComments";
    /// <summary>Identifies the ReasonNotContacted entity attribute.</summary>
    public const string ReasonNotContactedField = "ReasonNotContacted";
    /// <summary>Identifies the StaffId entity attribute.</summary>
    public const string StaffIdField = "StaffId";
    /// <summary>Identifies the Smokelyzer entity attribute.</summary>
    public const string SmokelyzerField = "Smokelyzer";
    /// <summary>Identifies the IdId entity attribute.</summary>
    public const string IdIdField = "IdId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("AukatiFollowups")]
    private readonly EntityHolder<Client> _id = new EntityHolder<Client>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Client Id
    {
      get { return Get(_id); }
      set { Set(_id, value); }
    }


    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Provider
    {
      get { return Get(ref _provider, "Provider"); }
      set { Set(ref _provider, value, "Provider"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public double ClientId
    {
      get { return Get(ref _clientId, "ClientId"); }
      set { Set(ref _clientId, value, "ClientId"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string FollowUpType
    {
      get { return Get(ref _followUpType, "FollowUpType"); }
      set { Set(ref _followUpType, value, "FollowUpType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime FollowUpDate
    {
      get { return Get(ref _followUpDate, "FollowUpDate"); }
      set { Set(ref _followUpDate, value, "FollowUpDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int AssessmentId
    {
      get { return Get(ref _assessmentId, "AssessmentId"); }
      set { Set(ref _assessmentId, value, "AssessmentId"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ContactType
    {
      get { return Get(ref _contactType, "ContactType"); }
      set { Set(ref _contactType, value, "ContactType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ReasonWhyNot
    {
      get { return Get(ref _reasonWhyNot, "ReasonWhyNot"); }
      set { Set(ref _reasonWhyNot, value, "ReasonWhyNot"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string QuitStatus
    {
      get { return Get(ref _quitStatus, "QuitStatus"); }
      set { Set(ref _quitStatus, value, "QuitStatus"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ReasonForStarting
    {
      get { return Get(ref _reasonForStarting, "ReasonForStarting"); }
      set { Set(ref _reasonForStarting, value, "ReasonForStarting"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string SmokingAtHome
    {
      get { return Get(ref _smokingAtHome, "SmokingAtHome"); }
      set { Set(ref _smokingAtHome, value, "SmokingAtHome"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string SmokingInCar
    {
      get { return Get(ref _smokingInCar, "SmokingInCar"); }
      set { Set(ref _smokingInCar, value, "SmokingInCar"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string GeneralComments
    {
      get { return Get(ref _generalComments, "GeneralComments"); }
      set { Set(ref _generalComments, value, "GeneralComments"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ReasonNotContacted
    {
      get { return Get(ref _reasonNotContacted, "ReasonNotContacted"); }
      set { Set(ref _reasonNotContacted, value, "ReasonNotContacted"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string StaffId
    {
      get { return Get(ref _staffId, "StaffId"); }
      set { Set(ref _staffId, value, "StaffId"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Smokelyzer
    {
      get { return Get(ref _smokelyzer, "Smokelyzer"); }
      set { Set(ref _smokelyzer, value, "Smokelyzer"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Id" /> property.</summary>
    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int IdId
    {
      get { return Get(ref _idId, "IdId"); }
      set { Set(ref _idId, value, "IdId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  [Table("Clients")]
  public partial class Client : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _provider;
    [ValidatePresence]
    [ValidateLength(0, 25)]
    private string _lastName;
    [ValidatePresence]
    [ValidateLength(0, 25)]
    private string _firstNames;
    [ValidateLength(0, 50)]
    private string _title;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _gender;
    [ValidateLength(0, 35)]
    private string _residence;
    [ValidateLength(0, 30)]
    private string _address2;
    [ValidateLength(0, 30)]
    private string _suburb;
    [ValidateLength(0, 35)]
    private string _city;
    [ValidateLength(0, 15)]
    private string _homePhoneNumber;
    [ValidateLength(0, 15)]
    private string _workPhoneNumber;
    [ValidateEmailAddress]
    [ValidateLength(0, 75)]
    private string _emailAddress;
    private System.Nullable<System.DateTime> _dateofBirth;
    private System.Nullable<short> _doctor;
    [ValidateLength(0, 6)]
    private string _primaryStaffMember;
    [ValidateLength(0, 7)]
    private string _nhiNumber;
    [ValidateLength(0, 50)]
    private string _maritalStatus;
    private System.Nullable<System.DateTime> _registrationDate;
    [ValidateLength(0, 50)]
    private string _firstReferralSource;
    [ValidateLength(0, 16)]
    private string _csCardNumber;
    [ValidateLength(0, 50)]
    private string _status;
    private string _emergencyContactDetails;
    private System.Nullable<System.DateTime> _resignationDate;
    private string _comments;
    private System.Nullable<short> _midwife;
    [ValidateLength(0, 15)]
    private string _mobilePhone;
    [ValidateLength(0, 75)]
    private string _groupingCode;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Provider entity attribute.</summary>
    public const string ProviderField = "Provider";
    /// <summary>Identifies the LastName entity attribute.</summary>
    public const string LastNameField = "LastName";
    /// <summary>Identifies the FirstNames entity attribute.</summary>
    public const string FirstNamesField = "FirstNames";
    /// <summary>Identifies the Title entity attribute.</summary>
    public const string TitleField = "Title";
    /// <summary>Identifies the Gender entity attribute.</summary>
    public const string GenderField = "Gender";
    /// <summary>Identifies the Residence entity attribute.</summary>
    public const string ResidenceField = "Residence";
    /// <summary>Identifies the Address2 entity attribute.</summary>
    public const string Address2Field = "Address2";
    /// <summary>Identifies the Suburb entity attribute.</summary>
    public const string SuburbField = "Suburb";
    /// <summary>Identifies the City entity attribute.</summary>
    public const string CityField = "City";
    /// <summary>Identifies the HomePhoneNumber entity attribute.</summary>
    public const string HomePhoneNumberField = "HomePhoneNumber";
    /// <summary>Identifies the WorkPhoneNumber entity attribute.</summary>
    public const string WorkPhoneNumberField = "WorkPhoneNumber";
    /// <summary>Identifies the EmailAddress entity attribute.</summary>
    public const string EmailAddressField = "EmailAddress";
    /// <summary>Identifies the DateofBirth entity attribute.</summary>
    public const string DateofBirthField = "DateofBirth";
    /// <summary>Identifies the Doctor entity attribute.</summary>
    public const string DoctorField = "Doctor";
    /// <summary>Identifies the PrimaryStaffMember entity attribute.</summary>
    public const string PrimaryStaffMemberField = "PrimaryStaffMember";
    /// <summary>Identifies the NhiNumber entity attribute.</summary>
    public const string NhiNumberField = "NhiNumber";
    /// <summary>Identifies the MaritalStatus entity attribute.</summary>
    public const string MaritalStatusField = "MaritalStatus";
    /// <summary>Identifies the RegistrationDate entity attribute.</summary>
    public const string RegistrationDateField = "RegistrationDate";
    /// <summary>Identifies the FirstReferralSource entity attribute.</summary>
    public const string FirstReferralSourceField = "FirstReferralSource";
    /// <summary>Identifies the CsCardNumber entity attribute.</summary>
    public const string CsCardNumberField = "CsCardNumber";
    /// <summary>Identifies the Status entity attribute.</summary>
    public const string StatusField = "Status";
    /// <summary>Identifies the EmergencyContactDetails entity attribute.</summary>
    public const string EmergencyContactDetailsField = "EmergencyContactDetails";
    /// <summary>Identifies the ResignationDate entity attribute.</summary>
    public const string ResignationDateField = "ResignationDate";
    /// <summary>Identifies the Comments entity attribute.</summary>
    public const string CommentsField = "Comments";
    /// <summary>Identifies the Midwife entity attribute.</summary>
    public const string MidwifeField = "Midwife";
    /// <summary>Identifies the MobilePhone entity attribute.</summary>
    public const string MobilePhoneField = "MobilePhone";
    /// <summary>Identifies the GroupingCode entity attribute.</summary>
    public const string GroupingCodeField = "GroupingCode";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Client")]
    private EntityCollection<AukatiAssessment> _aukatiAssessments = new EntityCollection<AukatiAssessment>();
    [ReverseAssociation("Id")]
    private EntityCollection<AukatiFollowup> _aukatiFollowups = new EntityCollection<AukatiFollowup>();
    [ReverseAssociation("Client")]
    private EntityCollection<ClientsEthnicity> _clientsEthnicities = new EntityCollection<ClientsEthnicity>();
    [ReverseAssociation("Client")]
    private EntityCollection<ClientsHapu> _clientsHapus = new EntityCollection<ClientsHapu>();
    [ReverseAssociation("Client")]
    private EntityCollection<ClientsIwi> _clientsIwis = new EntityCollection<ClientsIwi>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<AukatiAssessment> AukatiAssessments
    {
      get { return Get(_aukatiAssessments); }
      set { _aukatiAssessments = value; }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<AukatiFollowup> AukatiFollowups
    {
      get { return Get(_aukatiFollowups); }
      set { _aukatiFollowups = value; }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<ClientsEthnicity> ClientsEthnicities
    {
      get { return Get(_clientsEthnicities); }
      set { _clientsEthnicities = value; }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<ClientsHapu> ClientsHapus
    {
      get { return Get(_clientsHapus); }
      set { _clientsHapus = value; }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<ClientsIwi> ClientsIwis
    {
      get { return Get(_clientsIwis); }
      set { _clientsIwis = value; }
    }


    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Provider
    {
      get { return Get(ref _provider, "Provider"); }
      set { Set(ref _provider, value, "Provider"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string LastName
    {
      get { return Get(ref _lastName, "LastName"); }
      set { Set(ref _lastName, value, "LastName"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string FirstNames
    {
      get { return Get(ref _firstNames, "FirstNames"); }
      set { Set(ref _firstNames, value, "FirstNames"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Title
    {
      get { return Get(ref _title, "Title"); }
      set { Set(ref _title, value, "Title"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Gender
    {
      get { return Get(ref _gender, "Gender"); }
      set { Set(ref _gender, value, "Gender"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Residence
    {
      get { return Get(ref _residence, "Residence"); }
      set { Set(ref _residence, value, "Residence"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Address2
    {
      get { return Get(ref _address2, "Address2"); }
      set { Set(ref _address2, value, "Address2"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Suburb
    {
      get { return Get(ref _suburb, "Suburb"); }
      set { Set(ref _suburb, value, "Suburb"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string City
    {
      get { return Get(ref _city, "City"); }
      set { Set(ref _city, value, "City"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string HomePhoneNumber
    {
      get { return Get(ref _homePhoneNumber, "HomePhoneNumber"); }
      set { Set(ref _homePhoneNumber, value, "HomePhoneNumber"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string WorkPhoneNumber
    {
      get { return Get(ref _workPhoneNumber, "WorkPhoneNumber"); }
      set { Set(ref _workPhoneNumber, value, "WorkPhoneNumber"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string EmailAddress
    {
      get { return Get(ref _emailAddress, "EmailAddress"); }
      set { Set(ref _emailAddress, value, "EmailAddress"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> DateofBirth
    {
      get { return Get(ref _dateofBirth, "DateofBirth"); }
      set { Set(ref _dateofBirth, value, "DateofBirth"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<short> Doctor
    {
      get { return Get(ref _doctor, "Doctor"); }
      set { Set(ref _doctor, value, "Doctor"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string PrimaryStaffMember
    {
      get { return Get(ref _primaryStaffMember, "PrimaryStaffMember"); }
      set { Set(ref _primaryStaffMember, value, "PrimaryStaffMember"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string NhiNumber
    {
      get { return Get(ref _nhiNumber, "NhiNumber"); }
      set { Set(ref _nhiNumber, value, "NhiNumber"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MaritalStatus
    {
      get { return Get(ref _maritalStatus, "MaritalStatus"); }
      set { Set(ref _maritalStatus, value, "MaritalStatus"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> RegistrationDate
    {
      get { return Get(ref _registrationDate, "RegistrationDate"); }
      set { Set(ref _registrationDate, value, "RegistrationDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string FirstReferralSource
    {
      get { return Get(ref _firstReferralSource, "FirstReferralSource"); }
      set { Set(ref _firstReferralSource, value, "FirstReferralSource"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CsCardNumber
    {
      get { return Get(ref _csCardNumber, "CsCardNumber"); }
      set { Set(ref _csCardNumber, value, "CsCardNumber"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Status
    {
      get { return Get(ref _status, "Status"); }
      set { Set(ref _status, value, "Status"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string EmergencyContactDetails
    {
      get { return Get(ref _emergencyContactDetails, "EmergencyContactDetails"); }
      set { Set(ref _emergencyContactDetails, value, "EmergencyContactDetails"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> ResignationDate
    {
      get { return Get(ref _resignationDate, "ResignationDate"); }
      set { Set(ref _resignationDate, value, "ResignationDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Comments
    {
      get { return Get(ref _comments, "Comments"); }
      set { Set(ref _comments, value, "Comments"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<short> Midwife
    {
      get { return Get(ref _midwife, "Midwife"); }
      set { Set(ref _midwife, value, "Midwife"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MobilePhone
    {
      get { return Get(ref _mobilePhone, "MobilePhone"); }
      set { Set(ref _mobilePhone, value, "MobilePhone"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string GroupingCode
    {
      get { return Get(ref _groupingCode, "GroupingCode"); }
      set { Set(ref _groupingCode, value, "GroupingCode"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  public partial class ClientsEthnicity : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _provider;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _ethnicity;
    private int _clientId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Provider entity attribute.</summary>
    public const string ProviderField = "Provider";
    /// <summary>Identifies the Ethnicity entity attribute.</summary>
    public const string EthnicityField = "Ethnicity";
    /// <summary>Identifies the ClientId entity attribute.</summary>
    public const string ClientIdField = "ClientId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("ClientsEthnicities")]
    private readonly EntityHolder<Client> _client = new EntityHolder<Client>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Client Client
    {
      get { return Get(_client); }
      set { Set(_client, value); }
    }


    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Provider
    {
      get { return Get(ref _provider, "Provider"); }
      set { Set(ref _provider, value, "Provider"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Ethnicity
    {
      get { return Get(ref _ethnicity, "Ethnicity"); }
      set { Set(ref _ethnicity, value, "Ethnicity"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Client" /> property.</summary>
    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int ClientId
    {
      get { return Get(ref _clientId, "ClientId"); }
      set { Set(ref _clientId, value, "ClientId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  public partial class ClientsHapu : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _provider;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _hapu;
    private int _clientId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Provider entity attribute.</summary>
    public const string ProviderField = "Provider";
    /// <summary>Identifies the Hapu entity attribute.</summary>
    public const string HapuField = "Hapu";
    /// <summary>Identifies the ClientId entity attribute.</summary>
    public const string ClientIdField = "ClientId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("ClientsHapus")]
    private readonly EntityHolder<Client> _client = new EntityHolder<Client>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Client Client
    {
      get { return Get(_client); }
      set { Set(_client, value); }
    }


    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Provider
    {
      get { return Get(ref _provider, "Provider"); }
      set { Set(ref _provider, value, "Provider"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Hapu
    {
      get { return Get(ref _hapu, "Hapu"); }
      set { Set(ref _hapu, value, "Hapu"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Client" /> property.</summary>
    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int ClientId
    {
      get { return Get(ref _clientId, "ClientId"); }
      set { Set(ref _clientId, value, "ClientId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the LightSpeedModel model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class LightSpeedModelUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<AukatiAssessment> AukatiAssessments
    {
      get { return this.Query<AukatiAssessment>(); }
    }
    
    public System.Linq.IQueryable<ClientsIwi> ClientsIwis
    {
      get { return this.Query<ClientsIwi>(); }
    }
    
    public System.Linq.IQueryable<AukatiFollowup> AukatiFollowups
    {
      get { return this.Query<AukatiFollowup>(); }
    }
    
    public System.Linq.IQueryable<Client> Clients
    {
      get { return this.Query<Client>(); }
    }
    
    public System.Linq.IQueryable<ClientsEthnicity> ClientsEthnicities
    {
      get { return this.Query<ClientsEthnicity>(); }
    }
    
    public System.Linq.IQueryable<ClientsHapu> ClientsHapus
    {
      get { return this.Query<ClientsHapu>(); }
    }
    
  }

#if LS3_DTOS

  namespace Contracts.Data
  {
    [System.Runtime.Serialization.DataContract(Name="LightSpeedModelDtoBase")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class LightSpeedModelDtoBase
    {
    }

    [System.Runtime.Serialization.DataContract(Name="AukatiAssessment")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class AukatiAssessmentDto : LightSpeedModelDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Provider { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int AssessmentId { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.DateTime EnrolmentDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ProgrammeStatus { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<int> Age { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<int> StartSmokingAge { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<int> TimeoffSmoking { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string PregnancyStatus { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string NumberofTailorMades { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AmountofLooseTobacco { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Smokingathome { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string SmokinginCar { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string HouseholdNumber { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Under5 { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string RegularSmokers { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Comments { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string HeardaboutService { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string PrimaryMotivationtoQuit { get; set; }
      [System.Runtime.Serialization.DataMember]
      public bool Brupropion { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string FirstCigarette { get; set; }
      [System.Runtime.Serialization.DataMember]
      public bool Nortryptyline { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<short> ReferralId { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Smokelyzer { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> TqDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public bool Varenicline { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> ExitDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ExitType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int ClientId { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="ClientsIwi")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class ClientsIwiDto : LightSpeedModelDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Provider { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Iwi { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int ClientId { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="AukatiFollowup")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class AukatiFollowupDto : LightSpeedModelDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Provider { get; set; }
      [System.Runtime.Serialization.DataMember]
      public double ClientId { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string FollowUpType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.DateTime FollowUpDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int AssessmentId { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ContactType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ReasonWhyNot { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string QuitStatus { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ReasonForStarting { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string SmokingAtHome { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string SmokingInCar { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string GeneralComments { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ReasonNotContacted { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string StaffId { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Smokelyzer { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int IdId { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="Client")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class ClientDto : LightSpeedModelDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Provider { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string LastName { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string FirstNames { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Title { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Gender { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Residence { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Address2 { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Suburb { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string City { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string HomePhoneNumber { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string WorkPhoneNumber { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string EmailAddress { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> DateofBirth { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<short> Doctor { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string PrimaryStaffMember { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string NhiNumber { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MaritalStatus { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> RegistrationDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string FirstReferralSource { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CsCardNumber { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Status { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string EmergencyContactDetails { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> ResignationDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Comments { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<short> Midwife { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MobilePhone { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string GroupingCode { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="ClientsEthnicity")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class ClientsEthnicityDto : LightSpeedModelDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Provider { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Ethnicity { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int ClientId { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="ClientsHapu")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class ClientsHapuDto : LightSpeedModelDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Provider { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Hapu { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int ClientId { get; set; }
    }


    
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public static partial class LightSpeedModelDtoExtensions
    {
      static partial void CopyLightSpeedModelDtoBase(Entity entity, LightSpeedModelDtoBase dto);
      static partial void CopyLightSpeedModelDtoBase(LightSpeedModelDtoBase dto, Entity entity);

      static partial void BeforeCopyAukatiAssessment(AukatiAssessment entity, AukatiAssessmentDto dto);
      static partial void AfterCopyAukatiAssessment(AukatiAssessment entity, AukatiAssessmentDto dto);
      static partial void BeforeCopyAukatiAssessment(AukatiAssessmentDto dto, AukatiAssessment entity);
      static partial void AfterCopyAukatiAssessment(AukatiAssessmentDto dto, AukatiAssessment entity);
      
      private static void CopyAukatiAssessment(AukatiAssessment entity, AukatiAssessmentDto dto)
      {
        BeforeCopyAukatiAssessment(entity, dto);
        CopyLightSpeedModelDtoBase(entity, dto);
        dto.Provider = entity.Provider;
        dto.AssessmentId = entity.AssessmentId;
        dto.EnrolmentDate = entity.EnrolmentDate;
        dto.ProgrammeStatus = entity.ProgrammeStatus;
        dto.Age = entity.Age;
        dto.StartSmokingAge = entity.StartSmokingAge;
        dto.TimeoffSmoking = entity.TimeoffSmoking;
        dto.PregnancyStatus = entity.PregnancyStatus;
        dto.NumberofTailorMades = entity.NumberofTailorMades;
        dto.AmountofLooseTobacco = entity.AmountofLooseTobacco;
        dto.Smokingathome = entity.Smokingathome;
        dto.SmokinginCar = entity.SmokinginCar;
        dto.HouseholdNumber = entity.HouseholdNumber;
        dto.Under5 = entity.Under5;
        dto.RegularSmokers = entity.RegularSmokers;
        dto.Comments = entity.Comments;
        dto.HeardaboutService = entity.HeardaboutService;
        dto.PrimaryMotivationtoQuit = entity.PrimaryMotivationtoQuit;
        dto.Brupropion = entity.Brupropion;
        dto.FirstCigarette = entity.FirstCigarette;
        dto.Nortryptyline = entity.Nortryptyline;
        dto.ReferralId = entity.ReferralId;
        dto.Smokelyzer = entity.Smokelyzer;
        dto.TqDate = entity.TqDate;
        dto.Varenicline = entity.Varenicline;
        dto.ExitDate = entity.ExitDate;
        dto.ExitType = entity.ExitType;
        dto.ClientId = entity.ClientId;
        AfterCopyAukatiAssessment(entity, dto);
      }
      
      private static void CopyAukatiAssessment(AukatiAssessmentDto dto, AukatiAssessment entity)
      {
        BeforeCopyAukatiAssessment(dto, entity);
        CopyLightSpeedModelDtoBase(dto, entity);
        entity.Provider = dto.Provider;
        entity.AssessmentId = dto.AssessmentId;
        entity.EnrolmentDate = dto.EnrolmentDate;
        entity.ProgrammeStatus = dto.ProgrammeStatus;
        entity.Age = dto.Age;
        entity.StartSmokingAge = dto.StartSmokingAge;
        entity.TimeoffSmoking = dto.TimeoffSmoking;
        entity.PregnancyStatus = dto.PregnancyStatus;
        entity.NumberofTailorMades = dto.NumberofTailorMades;
        entity.AmountofLooseTobacco = dto.AmountofLooseTobacco;
        entity.Smokingathome = dto.Smokingathome;
        entity.SmokinginCar = dto.SmokinginCar;
        entity.HouseholdNumber = dto.HouseholdNumber;
        entity.Under5 = dto.Under5;
        entity.RegularSmokers = dto.RegularSmokers;
        entity.Comments = dto.Comments;
        entity.HeardaboutService = dto.HeardaboutService;
        entity.PrimaryMotivationtoQuit = dto.PrimaryMotivationtoQuit;
        entity.Brupropion = dto.Brupropion;
        entity.FirstCigarette = dto.FirstCigarette;
        entity.Nortryptyline = dto.Nortryptyline;
        entity.ReferralId = dto.ReferralId;
        entity.Smokelyzer = dto.Smokelyzer;
        entity.TqDate = dto.TqDate;
        entity.Varenicline = dto.Varenicline;
        entity.ExitDate = dto.ExitDate;
        entity.ExitType = dto.ExitType;
        entity.ClientId = dto.ClientId;
        AfterCopyAukatiAssessment(dto, entity);
      }
      
      public static AukatiAssessmentDto AsDto(this AukatiAssessment entity)
      {
        AukatiAssessmentDto dto = new AukatiAssessmentDto();
        CopyAukatiAssessment(entity, dto);
        return dto;
      }
      
      public static AukatiAssessment CopyTo(this AukatiAssessmentDto source, AukatiAssessment entity)
      {
        CopyAukatiAssessment(source, entity);
        return entity;
      }

      static partial void BeforeCopyClientsIwi(ClientsIwi entity, ClientsIwiDto dto);
      static partial void AfterCopyClientsIwi(ClientsIwi entity, ClientsIwiDto dto);
      static partial void BeforeCopyClientsIwi(ClientsIwiDto dto, ClientsIwi entity);
      static partial void AfterCopyClientsIwi(ClientsIwiDto dto, ClientsIwi entity);
      
      private static void CopyClientsIwi(ClientsIwi entity, ClientsIwiDto dto)
      {
        BeforeCopyClientsIwi(entity, dto);
        CopyLightSpeedModelDtoBase(entity, dto);
        dto.Provider = entity.Provider;
        dto.Iwi = entity.Iwi;
        dto.ClientId = entity.ClientId;
        AfterCopyClientsIwi(entity, dto);
      }
      
      private static void CopyClientsIwi(ClientsIwiDto dto, ClientsIwi entity)
      {
        BeforeCopyClientsIwi(dto, entity);
        CopyLightSpeedModelDtoBase(dto, entity);
        entity.Provider = dto.Provider;
        entity.Iwi = dto.Iwi;
        entity.ClientId = dto.ClientId;
        AfterCopyClientsIwi(dto, entity);
      }
      
      public static ClientsIwiDto AsDto(this ClientsIwi entity)
      {
        ClientsIwiDto dto = new ClientsIwiDto();
        CopyClientsIwi(entity, dto);
        return dto;
      }
      
      public static ClientsIwi CopyTo(this ClientsIwiDto source, ClientsIwi entity)
      {
        CopyClientsIwi(source, entity);
        return entity;
      }

      static partial void BeforeCopyAukatiFollowup(AukatiFollowup entity, AukatiFollowupDto dto);
      static partial void AfterCopyAukatiFollowup(AukatiFollowup entity, AukatiFollowupDto dto);
      static partial void BeforeCopyAukatiFollowup(AukatiFollowupDto dto, AukatiFollowup entity);
      static partial void AfterCopyAukatiFollowup(AukatiFollowupDto dto, AukatiFollowup entity);
      
      private static void CopyAukatiFollowup(AukatiFollowup entity, AukatiFollowupDto dto)
      {
        BeforeCopyAukatiFollowup(entity, dto);
        CopyLightSpeedModelDtoBase(entity, dto);
        dto.Provider = entity.Provider;
        dto.ClientId = entity.ClientId;
        dto.FollowUpType = entity.FollowUpType;
        dto.FollowUpDate = entity.FollowUpDate;
        dto.AssessmentId = entity.AssessmentId;
        dto.ContactType = entity.ContactType;
        dto.ReasonWhyNot = entity.ReasonWhyNot;
        dto.QuitStatus = entity.QuitStatus;
        dto.ReasonForStarting = entity.ReasonForStarting;
        dto.SmokingAtHome = entity.SmokingAtHome;
        dto.SmokingInCar = entity.SmokingInCar;
        dto.GeneralComments = entity.GeneralComments;
        dto.ReasonNotContacted = entity.ReasonNotContacted;
        dto.StaffId = entity.StaffId;
        dto.Smokelyzer = entity.Smokelyzer;
        dto.IdId = entity.IdId;
        AfterCopyAukatiFollowup(entity, dto);
      }
      
      private static void CopyAukatiFollowup(AukatiFollowupDto dto, AukatiFollowup entity)
      {
        BeforeCopyAukatiFollowup(dto, entity);
        CopyLightSpeedModelDtoBase(dto, entity);
        entity.Provider = dto.Provider;
        entity.ClientId = dto.ClientId;
        entity.FollowUpType = dto.FollowUpType;
        entity.FollowUpDate = dto.FollowUpDate;
        entity.AssessmentId = dto.AssessmentId;
        entity.ContactType = dto.ContactType;
        entity.ReasonWhyNot = dto.ReasonWhyNot;
        entity.QuitStatus = dto.QuitStatus;
        entity.ReasonForStarting = dto.ReasonForStarting;
        entity.SmokingAtHome = dto.SmokingAtHome;
        entity.SmokingInCar = dto.SmokingInCar;
        entity.GeneralComments = dto.GeneralComments;
        entity.ReasonNotContacted = dto.ReasonNotContacted;
        entity.StaffId = dto.StaffId;
        entity.Smokelyzer = dto.Smokelyzer;
        entity.IdId = dto.IdId;
        AfterCopyAukatiFollowup(dto, entity);
      }
      
      public static AukatiFollowupDto AsDto(this AukatiFollowup entity)
      {
        AukatiFollowupDto dto = new AukatiFollowupDto();
        CopyAukatiFollowup(entity, dto);
        return dto;
      }
      
      public static AukatiFollowup CopyTo(this AukatiFollowupDto source, AukatiFollowup entity)
      {
        CopyAukatiFollowup(source, entity);
        return entity;
      }

      static partial void BeforeCopyClient(Client entity, ClientDto dto);
      static partial void AfterCopyClient(Client entity, ClientDto dto);
      static partial void BeforeCopyClient(ClientDto dto, Client entity);
      static partial void AfterCopyClient(ClientDto dto, Client entity);
      
      private static void CopyClient(Client entity, ClientDto dto)
      {
        BeforeCopyClient(entity, dto);
        CopyLightSpeedModelDtoBase(entity, dto);
        dto.Provider = entity.Provider;
        dto.LastName = entity.LastName;
        dto.FirstNames = entity.FirstNames;
        dto.Title = entity.Title;
        dto.Gender = entity.Gender;
        dto.Residence = entity.Residence;
        dto.Address2 = entity.Address2;
        dto.Suburb = entity.Suburb;
        dto.City = entity.City;
        dto.HomePhoneNumber = entity.HomePhoneNumber;
        dto.WorkPhoneNumber = entity.WorkPhoneNumber;
        dto.EmailAddress = entity.EmailAddress;
        dto.DateofBirth = entity.DateofBirth;
        dto.Doctor = entity.Doctor;
        dto.PrimaryStaffMember = entity.PrimaryStaffMember;
        dto.NhiNumber = entity.NhiNumber;
        dto.MaritalStatus = entity.MaritalStatus;
        dto.RegistrationDate = entity.RegistrationDate;
        dto.FirstReferralSource = entity.FirstReferralSource;
        dto.CsCardNumber = entity.CsCardNumber;
        dto.Status = entity.Status;
        dto.EmergencyContactDetails = entity.EmergencyContactDetails;
        dto.ResignationDate = entity.ResignationDate;
        dto.Comments = entity.Comments;
        dto.Midwife = entity.Midwife;
        dto.MobilePhone = entity.MobilePhone;
        dto.GroupingCode = entity.GroupingCode;
        AfterCopyClient(entity, dto);
      }
      
      private static void CopyClient(ClientDto dto, Client entity)
      {
        BeforeCopyClient(dto, entity);
        CopyLightSpeedModelDtoBase(dto, entity);
        entity.Provider = dto.Provider;
        entity.LastName = dto.LastName;
        entity.FirstNames = dto.FirstNames;
        entity.Title = dto.Title;
        entity.Gender = dto.Gender;
        entity.Residence = dto.Residence;
        entity.Address2 = dto.Address2;
        entity.Suburb = dto.Suburb;
        entity.City = dto.City;
        entity.HomePhoneNumber = dto.HomePhoneNumber;
        entity.WorkPhoneNumber = dto.WorkPhoneNumber;
        entity.EmailAddress = dto.EmailAddress;
        entity.DateofBirth = dto.DateofBirth;
        entity.Doctor = dto.Doctor;
        entity.PrimaryStaffMember = dto.PrimaryStaffMember;
        entity.NhiNumber = dto.NhiNumber;
        entity.MaritalStatus = dto.MaritalStatus;
        entity.RegistrationDate = dto.RegistrationDate;
        entity.FirstReferralSource = dto.FirstReferralSource;
        entity.CsCardNumber = dto.CsCardNumber;
        entity.Status = dto.Status;
        entity.EmergencyContactDetails = dto.EmergencyContactDetails;
        entity.ResignationDate = dto.ResignationDate;
        entity.Comments = dto.Comments;
        entity.Midwife = dto.Midwife;
        entity.MobilePhone = dto.MobilePhone;
        entity.GroupingCode = dto.GroupingCode;
        AfterCopyClient(dto, entity);
      }
      
      public static ClientDto AsDto(this Client entity)
      {
        ClientDto dto = new ClientDto();
        CopyClient(entity, dto);
        return dto;
      }
      
      public static Client CopyTo(this ClientDto source, Client entity)
      {
        CopyClient(source, entity);
        return entity;
      }

      static partial void BeforeCopyClientsEthnicity(ClientsEthnicity entity, ClientsEthnicityDto dto);
      static partial void AfterCopyClientsEthnicity(ClientsEthnicity entity, ClientsEthnicityDto dto);
      static partial void BeforeCopyClientsEthnicity(ClientsEthnicityDto dto, ClientsEthnicity entity);
      static partial void AfterCopyClientsEthnicity(ClientsEthnicityDto dto, ClientsEthnicity entity);
      
      private static void CopyClientsEthnicity(ClientsEthnicity entity, ClientsEthnicityDto dto)
      {
        BeforeCopyClientsEthnicity(entity, dto);
        CopyLightSpeedModelDtoBase(entity, dto);
        dto.Provider = entity.Provider;
        dto.Ethnicity = entity.Ethnicity;
        dto.ClientId = entity.ClientId;
        AfterCopyClientsEthnicity(entity, dto);
      }
      
      private static void CopyClientsEthnicity(ClientsEthnicityDto dto, ClientsEthnicity entity)
      {
        BeforeCopyClientsEthnicity(dto, entity);
        CopyLightSpeedModelDtoBase(dto, entity);
        entity.Provider = dto.Provider;
        entity.Ethnicity = dto.Ethnicity;
        entity.ClientId = dto.ClientId;
        AfterCopyClientsEthnicity(dto, entity);
      }
      
      public static ClientsEthnicityDto AsDto(this ClientsEthnicity entity)
      {
        ClientsEthnicityDto dto = new ClientsEthnicityDto();
        CopyClientsEthnicity(entity, dto);
        return dto;
      }
      
      public static ClientsEthnicity CopyTo(this ClientsEthnicityDto source, ClientsEthnicity entity)
      {
        CopyClientsEthnicity(source, entity);
        return entity;
      }

      static partial void BeforeCopyClientsHapu(ClientsHapu entity, ClientsHapuDto dto);
      static partial void AfterCopyClientsHapu(ClientsHapu entity, ClientsHapuDto dto);
      static partial void BeforeCopyClientsHapu(ClientsHapuDto dto, ClientsHapu entity);
      static partial void AfterCopyClientsHapu(ClientsHapuDto dto, ClientsHapu entity);
      
      private static void CopyClientsHapu(ClientsHapu entity, ClientsHapuDto dto)
      {
        BeforeCopyClientsHapu(entity, dto);
        CopyLightSpeedModelDtoBase(entity, dto);
        dto.Provider = entity.Provider;
        dto.Hapu = entity.Hapu;
        dto.ClientId = entity.ClientId;
        AfterCopyClientsHapu(entity, dto);
      }
      
      private static void CopyClientsHapu(ClientsHapuDto dto, ClientsHapu entity)
      {
        BeforeCopyClientsHapu(dto, entity);
        CopyLightSpeedModelDtoBase(dto, entity);
        entity.Provider = dto.Provider;
        entity.Hapu = dto.Hapu;
        entity.ClientId = dto.ClientId;
        AfterCopyClientsHapu(dto, entity);
      }
      
      public static ClientsHapuDto AsDto(this ClientsHapu entity)
      {
        ClientsHapuDto dto = new ClientsHapuDto();
        CopyClientsHapu(entity, dto);
        return dto;
      }
      
      public static ClientsHapu CopyTo(this ClientsHapuDto source, ClientsHapu entity)
      {
        CopyClientsHapu(source, entity);
        return entity;
      }


    }

  }

#endif
}
