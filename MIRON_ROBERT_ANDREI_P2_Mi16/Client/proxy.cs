﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Categories", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class Categories : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CategoryNameField;
        
        private int ID_CategoryField;
        
        private MyPhotos.PicTable[] PicTableField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName
        {
            get
            {
                return this.CategoryNameField;
            }
            set
            {
                this.CategoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Category
        {
            get
            {
                return this.ID_CategoryField;
            }
            set
            {
                this.ID_CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.PicTable[] PicTable
        {
            get
            {
                return this.PicTableField;
            }
            set
            {
                this.PicTableField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PicTable", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class PicTable : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private MyPhotos.Categories[] CategoriesField;
        
        private System.DateTime Data_createField;
        
        private string DescriptionField;
        
        private int ID_IMGField;
        
        private string LocationField;
        
        private string Name_imgField;
        
        private string PathField;
        
        private MyPhotos.Person[] PersonField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.Categories[] Categories
        {
            get
            {
                return this.CategoriesField;
            }
            set
            {
                this.CategoriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data_create
        {
            get
            {
                return this.Data_createField;
            }
            set
            {
                this.Data_createField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_IMG
        {
            get
            {
                return this.ID_IMGField;
            }
            set
            {
                this.ID_IMGField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name_img
        {
            get
            {
                return this.Name_imgField;
            }
            set
            {
                this.Name_imgField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.Person[] Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string FirstNameField;
        
        private int ID_PersonField;
        
        private MyPhotos.PicTable[] PicTableField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Person
        {
            get
            {
                return this.ID_PersonField;
            }
            set
            {
                this.ID_PersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.PicTable[] PicTable
        {
            get
            {
                return this.PicTableField;
            }
            set
            {
                this.PicTableField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMyPhotosService")]
public interface IMyPhotosService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategories/isInCategories", ReplyAction="http://tempuri.org/ICategories/isInCategoriesResponse")]
    bool isInCategories(string index);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategories/isInCategories", ReplyAction="http://tempuri.org/ICategories/isInCategoriesResponse")]
    System.Threading.Tasks.Task<bool> isInCategoriesAsync(string index);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategories/GetCategoriesById", ReplyAction="http://tempuri.org/ICategories/GetCategoriesByIdResponse")]
    MyPhotos.Categories[] GetCategoriesById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategories/GetCategoriesById", ReplyAction="http://tempuri.org/ICategories/GetCategoriesByIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.Categories[]> GetCategoriesByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/existPerson", ReplyAction="http://tempuri.org/IPerson/existPersonResponse")]
    bool existPerson(string nameP);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPerson/existPerson", ReplyAction="http://tempuri.org/IPerson/existPersonResponse")]
    System.Threading.Tasks.Task<bool> existPersonAsync(string nameP);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/AddEntry", ReplyAction="http://tempuri.org/IPicTable/AddEntryResponse")]
    void AddEntry(string name, string path, string description, string location, System.DateTime dt, string[] categories, string[] peoplys);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/AddEntry", ReplyAction="http://tempuri.org/IPicTable/AddEntryResponse")]
    System.Threading.Tasks.Task AddEntryAsync(string name, string path, string description, string location, System.DateTime dt, string[] categories, string[] peoplys);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/updateEntry", ReplyAction="http://tempuri.org/IPicTable/updateEntryResponse")]
    void updateEntry(int id, string title, string description, string location, string[] categories, string[] peoples);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/updateEntry", ReplyAction="http://tempuri.org/IPicTable/updateEntryResponse")]
    System.Threading.Tasks.Task updateEntryAsync(int id, string title, string description, string location, string[] categories, string[] peoples);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/GetAllPicsForLoad", ReplyAction="http://tempuri.org/IPicTable/GetAllPicsForLoadResponse")]
    MyPhotos.PicTable[] GetAllPicsForLoad();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/GetAllPicsForLoad", ReplyAction="http://tempuri.org/IPicTable/GetAllPicsForLoadResponse")]
    System.Threading.Tasks.Task<MyPhotos.PicTable[]> GetAllPicsForLoadAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/RemoveEntry", ReplyAction="http://tempuri.org/IPicTable/RemoveEntryResponse")]
    void RemoveEntry(int ImageIndex);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/RemoveEntry", ReplyAction="http://tempuri.org/IPicTable/RemoveEntryResponse")]
    System.Threading.Tasks.Task RemoveEntryAsync(int ImageIndex);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/getDataFiltered", ReplyAction="http://tempuri.org/IPicTable/getDataFilteredResponse")]
    MyPhotos.PicTable[] getDataFiltered(string filterString, string text);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPicTable/getDataFiltered", ReplyAction="http://tempuri.org/IPicTable/getDataFilteredResponse")]
    System.Threading.Tasks.Task<MyPhotos.PicTable[]> getDataFilteredAsync(string filterString, string text);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyPhotosServiceChannel : IMyPhotosService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyPhotosServiceClient : System.ServiceModel.ClientBase<IMyPhotosService>, IMyPhotosService
{
    
    public MyPhotosServiceClient()
    {
    }
    
    public MyPhotosServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MyPhotosServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyPhotosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyPhotosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool isInCategories(string index)
    {
        return base.Channel.isInCategories(index);
    }
    
    public System.Threading.Tasks.Task<bool> isInCategoriesAsync(string index)
    {
        return base.Channel.isInCategoriesAsync(index);
    }
    
    public MyPhotos.Categories[] GetCategoriesById(int id)
    {
        return base.Channel.GetCategoriesById(id);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Categories[]> GetCategoriesByIdAsync(int id)
    {
        return base.Channel.GetCategoriesByIdAsync(id);
    }
    
    public bool existPerson(string nameP)
    {
        return base.Channel.existPerson(nameP);
    }
    
    public System.Threading.Tasks.Task<bool> existPersonAsync(string nameP)
    {
        return base.Channel.existPersonAsync(nameP);
    }
    
    public void AddEntry(string name, string path, string description, string location, System.DateTime dt, string[] categories, string[] peoplys)
    {
        base.Channel.AddEntry(name, path, description, location, dt, categories, peoplys);
    }
    
    public System.Threading.Tasks.Task AddEntryAsync(string name, string path, string description, string location, System.DateTime dt, string[] categories, string[] peoplys)
    {
        return base.Channel.AddEntryAsync(name, path, description, location, dt, categories, peoplys);
    }
    
    public void updateEntry(int id, string title, string description, string location, string[] categories, string[] peoples)
    {
        base.Channel.updateEntry(id, title, description, location, categories, peoples);
    }
    
    public System.Threading.Tasks.Task updateEntryAsync(int id, string title, string description, string location, string[] categories, string[] peoples)
    {
        return base.Channel.updateEntryAsync(id, title, description, location, categories, peoples);
    }
    
    public MyPhotos.PicTable[] GetAllPicsForLoad()
    {
        return base.Channel.GetAllPicsForLoad();
    }
    
    public System.Threading.Tasks.Task<MyPhotos.PicTable[]> GetAllPicsForLoadAsync()
    {
        return base.Channel.GetAllPicsForLoadAsync();
    }
    
    public void RemoveEntry(int ImageIndex)
    {
        base.Channel.RemoveEntry(ImageIndex);
    }
    
    public System.Threading.Tasks.Task RemoveEntryAsync(int ImageIndex)
    {
        return base.Channel.RemoveEntryAsync(ImageIndex);
    }
    
    public MyPhotos.PicTable[] getDataFiltered(string filterString, string text)
    {
        return base.Channel.getDataFiltered(filterString, text);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.PicTable[]> getDataFilteredAsync(string filterString, string text)
    {
        return base.Channel.getDataFilteredAsync(filterString, text);
    }
}