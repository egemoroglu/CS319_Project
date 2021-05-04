﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using PeeReview.Models;

namespace PeeReview.Controllers
{   
           public class Connector
           {
            static string connectionLink = "mongodb+srv://yigit:0Bijmmtw7s8XtX9x@cluster0.zosoz.mongodb.net/peereview?retryWrites=true&w=majority";
            static string dbname = "peereview";
            static MongoDB.Driver.MongoClient client = new MongoDB.Driver.MongoClient(connectionLink);
            string databaseName;

           public Connector(string tableName)
           {
                //var client = new MongoDB.Driver.MongoClient(connectionLink);
                databaseName = tableName;
           }

           void addUser(Models.User user)
           {
                //This document should retrieve info from User
                var document = new BsonDocument
                {
                //
                { "userType", "undefined" },

                //it is possible to assign attributes like following
                //user name
                { "userName", user.Name },
                { "surName", user.SurName },
                { "email", user.Email },
                { "psswd", user.Password },

                //PASSING ARRAY
                { "CourseList", new BsonArray { "", "" } },
                { "AssignmentList", new BsonArray { "", "" } },
                { "ProjectList", new BsonArray { "", "" } },
                { "GroupList", new BsonArray { "", "" } },

                //PASSING OBJ
                //{ "size", new BsonDocument { { "attribute_0", 28 }, { "attribute_1", 35.5 }, { "attribute_2", "cm" } } }
           };

                var database = client.GetDatabase(dbname);
                var collection = database.GetCollection<BsonDocument>(databaseName);
                collection.InsertOne(document);
           }

           public void addProject(Project project)
           {
                //This document should retrieve info from User
                var document = new BsonDocument
           {
                //public string Name { get; private set; }
                //public string ID { get; private set; }
                //public Note Description { get; private set; }
                //public int GroupSize { get; private set; }
                //public defaultSetUniqueID IDSetter { get; private set; }
                //public List<Group> Groups { get; }
                //public DateTime DeadlineDateTime;
                //public Course Course { get; private set; }
                //public List<Assignment> Assignments { get; private set; }
                //public DateTime ProjectDateTime { get; private set; }
                //public string deadlineErrorMessage { get; private set; }
                                              
                //
                { "ProjectName", project.Name },
                { "Description", project.Description.TextContent },
                { "groupSize", project.GroupSize },
                { "Deadline", project.DeadlineDateTime },
                { "Course", project.Course.CourseCode },

                //PASSING ARRAY
                { "GroupsList", new BsonArray { "", "" } },
                { "AssignmentsList", new BsonArray { "", "" } },
               
                //PASSING OBJ
                //{ "size", new BsonDocument { { "attribute_0", 28 }, { "attribute_1", 35.5 }, { "attribute_2", "cm" } } }
           };

           var database = client.GetDatabase(dbname);
           var collection = database.GetCollection<BsonDocument>(databaseName);
           collection.InsertOne(document);
           }

           void removeProject(Project project)
           {
                //find project
                var database = client.GetDatabase(dbname);
                var collection = database.GetCollection<BsonDocument>(databaseName);

                var deleteFilter = Builders<BsonDocument>.Filter.Eq("ProjectName", project.Name);
                collection.DeleteOne(deleteFilter);
                //remove course from database
           }

           void addAssignment(Assignment assignment)
           {
                var document = new BsonDocument
                {
                /*  public double grade;
                    public string title;
                    public string description;
                    public List<Submission> Submissions;
                    public List<CompletedSubmission> CompletedSubmissions;
                    public Assignment nextIteration { get; private set; }
                    public DateTime AssignmentDateTime { get; }

                    public DateTime deadlineDateTime;
                    public string deadlineErrorMessage { get; private set; }
                    public Evaluation Evaluation { get; private set; }

                    public CalculateAverageEvaluationsStrategyDefault averageCalculator { get; set; }   */

                { "AssignmentGrade", assignment.grade },
                { "AssignmentTitle", assignment.title },
                { "AssignmentDescription", assignment.description },
                { "AssignmentDeadline", assignment.deadlineDateTime },

                    //PASSING ARRAY
                    //{ "GroupsList", new BsonArray { "", "" } },
                    //{ "StudentsList", new BsonArray { "", "" } },
                    //{ "ProjectsList", new BsonArray { "", "" } },
                    //{ "GradersList", new BsonArray { "", "" } },

                    //PASSING OBJ
                    //{ "size", new BsonDocument { { "attribute_0", 28 }, { "attribute_1", 35.5 }, { "attribute_2", "cm" } } }
                };
           var database = client.GetDatabase(dbname);
           var collection = database.GetCollection<BsonDocument>(databaseName);
           collection.InsertOne(document);
           }

           void removeAssignment(Assignment assignment)
           {
                //find course
                var database = client.GetDatabase(dbname);
                var collection = database.GetCollection<BsonDocument>(databaseName);

                var deleteFilter = Builders<BsonDocument>.Filter.Eq("AssignmentName", assignment.title);
                collection.DeleteOne(deleteFilter);
                //remove course from database
           }

           public void addCourse(Course course)
           {
                var document = new BsonDocument
                {
                /*  public List<Project> Projects { get; }
                    public List<Group> Groups { get; }
                    public List<Student> Students { get; }
                    public string CourseName { get; set; }
                    public string CourseCode { get;  set; }
                    public int CourseGroupPolicy { get;  set; }
                    public Instructor Instructor { get; private set; }
                    public List<Grader> Graders { get; }
                    public List<Submission> SubmittedAssignments { get; }
                    public AssignmentController Assignments { get; }
                    public GroupController GroupController { get; }
                    public defaultSetUniqueID IDSetter { get; private set; }
                    public string ID { get; private set; }   */
                { "CourseName", course.CourseName },
                { "CourseCode", course.CourseCode },
                { "CourseGroupPolicy", course.CourseGroupPolicy },

                { "Instructor", course.Instructor.Name },

                //PASSING ARRAY
                { "GroupsList", new BsonArray { "", "" } },
                { "StudentsList", new BsonArray { "", "" } },
                { "ProjectsList", new BsonArray { "", "" } },
                { "GradersList", new BsonArray { "", "" } },

                //PASSING OBJ
                //{ "size", new BsonDocument { { "attribute_0", 28 }, { "attribute_1", 35.5 }, { "attribute_2", "cm" } } }
           };

           var database = client.GetDatabase(dbname);
           var collection = database.GetCollection<BsonDocument>(databaseName);
           collection.InsertOne(document);
           }

           public void removeCourse(Course course)
           {                //find course
                var database = client.GetDatabase(dbname);
                var collection = database.GetCollection<BsonDocument>(databaseName);

                var deleteFilter = Builders<BsonDocument>.Filter.Eq("CourseCode", course.CourseCode);
                collection.DeleteOne(deleteFilter);
                //remove course from database
           }

           /**
            * example call
            * in userController/studentController addUser/addStudent function creates a Connector obj with ("UserTable/StudentTable") //Check Constructor
            * Connector conn("UserTable");
            * conn.addStudent(Student student) //this line keeps the student's info in db
            *
            *addStudent adds the information to db
            * 
            * 
           */
           public void addStudent(Student student)
           {
                //This document should retrieve info from User
                var document = new BsonDocument
           {
                //
                { "userType", "Student" },

                //it is possible to assign attributes like following
                //user name
                { "userName", student.Name },
                { "surName", student.SurName },
                { "email", student.Email },
                { "psswd", student.Password },

                //PASSING ARRAY
                { "CourseList", new BsonArray { "", "" } },
                { "AssignmentList", new BsonArray { "", "" } },
                { "ProjectList", new BsonArray { "", "" } },
                { "GroupList", new BsonArray { "", "" } },

                //PASSING OBJ
                //{ "size", new BsonDocument { { "attribute_0", 28 }, { "attribute_1", 35.5 }, { "attribute_2", "cm" } } }
           };

           var database = client.GetDatabase(dbname);
           var collection = database.GetCollection<BsonDocument>(databaseName);
           collection.InsertOne(document);
           }

           public void removeStudent(Student student)
           {
                //find course
                var database = client.GetDatabase(dbname);
                var collection = database.GetCollection<BsonDocument>(databaseName);

                var deleteFilter = Builders<BsonDocument>.Filter.Eq("email", student.Email);
                collection.DeleteOne(deleteFilter);
                //remove course from database
           }

           //    static void Connect()
           //    {
           //var client = new MongoDB.Driver.MongoClient("mongodb+srv://yigit:0Bijmmtw7s8XtX9x@cluster0.zosoz.mongodb.net/peereview?retryWrites=true&w=majority");
           //Db name 
           //var database = client.GetDatabase("peereview");
           //To reach Collection
           //var collection = database.GetCollection<BsonDocument>("user_table");
           //
                       //insert document
           //var document = new BsonDocument
           //{
           //
           //  { "userType", "student" },

           //it is possible to assign attributes like following
           //user name
           //{ "userName", "Veli" },
           //{ "surName", "Demir" },
           //{ "email", "ali.demir@ug.bilkent.edu.tr" },
           //{ "psswd", "123123" },

           //PASSING ARRAY
           //{ "CourseList", new BsonArray { "CS461", "CS315" } },
           //{ "AssignmentList", new BsonArray { "" } },
           //{ "ProjectList", new BsonArray { "Term Project 315" } },
           //{ "GroupList", new BsonArray { "B14" } },

           //PASSING OBJ
           //{ "size", new BsonDocument { { "attribute_0", 28 }, { "attribute_1", 35.5 }, { "attribute_2", "cm" } } }
           //};
           //collection.InsertOne(document);

           //Retrive everything 
           //var filter = Builders<BsonDocument>.Filter.Empty;
           //var result = collection.Find(filter).ToList();

           //Retrive according to filter
           //var filter = Builders<BsonDocument>.Filter.Eq("dogOrCat", "Ali");
           //var result = collection.Find(filter).ToList();

           //step
           //foreach (var doc in result)
           //{
           //Console.WriteLine(doc.ToJson());
           //}
           //Console.WriteLine("Connection Open!");
           //}
           }
}