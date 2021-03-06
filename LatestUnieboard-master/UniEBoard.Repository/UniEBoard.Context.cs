﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniEBoard.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.Data.Entity.Core.Objects;
    
    public partial class UniEBoardDbContext : DbContext
    {
        public UniEBoardDbContext()
            : base("name=UniEBoardDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accreditation> Accreditations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTemplate> CourseTemplates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<BaseFile> BaseFiles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<QuestionChoice> QuestionChoices { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuizEntry> QuizEntries { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StaffCourse> StaffCourses { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ViewedMessage> ViewedMessages { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<GroupMessage> GroupMessages { get; set; }
        public DbSet<ModuleQuiz> ModuleQuizs { get; set; }
        public DbSet<AnswerQuestionChoice> AnswerQuestionChoices { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TopicPost> TopicPosts { get; set; }
        public DbSet<BaseQuestionTopic> BaseQuestionTopics { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Assets_WebPage> Assets_WebPage { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
