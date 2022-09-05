using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace Homework
{
    public class TrueFalseEngine
    {

        #region Private Fields

        private string fileName;
        private List<Question> questionsList;

        #endregion

        #region Constructors

        public TrueFalseEngine(string fileName)
        {
            this.fileName = fileName;
            questionsList = new List<Question>();
        }

        #endregion

        #region Public Properties

        public int Count
        { 
            get { return questionsList.Count; }
        }

        public Question this[int index]
        {
            get { return questionsList[index]; }
        }

        #endregion

        #region Public methods

        public void Add(string text, bool trueFalse)
        { 
            questionsList.Add(new Question(text, trueFalse));
        }

        public void Delete(int index)
        {
            if (index >=0 && index < questionsList.Count)
            {
                questionsList.RemoveAt(index);
            }
        }

        public void Load()
        { 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            questionsList = (List<Question>)serializer.Deserialize(fs);
            fs.Close();
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            serializer.Serialize(fs, questionsList);
            fs.Close();
        }

        #endregion
    }
}
