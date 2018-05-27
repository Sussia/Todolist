﻿using System;
using System.Collections.Generic;
using System.ServiceModel;


namespace TodoListLib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ITodoEditor" в коде и файле конфигурации.
    [ServiceContract]
    public interface ITodoEditor
    {
        [OperationContract]
        string GetList();

        [OperationContract]
        string GetTask(Task task);

        [OperationContract]
        void InitializeList(string tableName);

        [OperationContract]
        void AddTask(string task);

        [OperationContract]
        string FindTasks(string[] tags);

        [OperationContract]
        void DeleteTasks(string tasks);

        [OperationContract]
        void Save(string path);

        [OperationContract]
        void Load(string path);

        [OperationContract]
        void SaveMain(string tableName);
    }
}
