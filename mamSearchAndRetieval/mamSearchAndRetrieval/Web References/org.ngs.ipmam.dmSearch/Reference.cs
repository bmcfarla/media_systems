﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace mamSearchAndRetrieval.org.ngs.ipmam.dmSearch {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DMSearchSoap", Namespace="http://www.blue-order.com/ma/datamanagerws/dmsearch")]
    public partial class DMSearch : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SearchOperationCompleted;
        
        private System.Threading.SendOrPostCallback Search2OperationCompleted;
        
        private System.Threading.SendOrPostCallback FindByAttributeOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindByAttributeAndObjectClassOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindUniqueByAttributeAndObjectClassOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchExtOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchExt2OperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchExt3OperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchSegmentsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DMSearch() {
            this.Url = global::mamSearchAndRetrieval.Properties.Settings.Default.mamSearchAndRetrieval_org_ngs_ipmam_dmSearch_DMSearch;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SearchCompletedEventHandler SearchCompleted;
        
        /// <remarks/>
        public event Search2CompletedEventHandler Search2Completed;
        
        /// <remarks/>
        public event FindByAttributeCompletedEventHandler FindByAttributeCompleted;
        
        /// <remarks/>
        public event FindByAttributeAndObjectClassCompletedEventHandler FindByAttributeAndObjectClassCompleted;
        
        /// <remarks/>
        public event FindUniqueByAttributeAndObjectClassCompletedEventHandler FindUniqueByAttributeAndObjectClassCompleted;
        
        /// <remarks/>
        public event SearchExtCompletedEventHandler SearchExtCompleted;
        
        /// <remarks/>
        public event SearchExt2CompletedEventHandler SearchExt2Completed;
        
        /// <remarks/>
        public event SearchExt3CompletedEventHandler SearchExt3Completed;
        
        /// <remarks/>
        public event SearchSegmentsCompletedEventHandler SearchSegmentsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/Search", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Search(string accessKey, string queryDoc) {
            object[] results = this.Invoke("Search", new object[] {
                        accessKey,
                        queryDoc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SearchAsync(string accessKey, string queryDoc) {
            this.SearchAsync(accessKey, queryDoc, null);
        }
        
        /// <remarks/>
        public void SearchAsync(string accessKey, string queryDoc, object userState) {
            if ((this.SearchOperationCompleted == null)) {
                this.SearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchOperationCompleted);
            }
            this.InvokeAsync("Search", new object[] {
                        accessKey,
                        queryDoc}, this.SearchOperationCompleted, userState);
        }
        
        private void OnSearchOperationCompleted(object arg) {
            if ((this.SearchCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchCompleted(this, new SearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/Search2", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Search2(string accessKey, string queryDoc, string language) {
            object[] results = this.Invoke("Search2", new object[] {
                        accessKey,
                        queryDoc,
                        language});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Search2Async(string accessKey, string queryDoc, string language) {
            this.Search2Async(accessKey, queryDoc, language, null);
        }
        
        /// <remarks/>
        public void Search2Async(string accessKey, string queryDoc, string language, object userState) {
            if ((this.Search2OperationCompleted == null)) {
                this.Search2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearch2OperationCompleted);
            }
            this.InvokeAsync("Search2", new object[] {
                        accessKey,
                        queryDoc,
                        language}, this.Search2OperationCompleted, userState);
        }
        
        private void OnSearch2OperationCompleted(object arg) {
            if ((this.Search2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Search2Completed(this, new Search2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/FindByAttribute", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] FindByAttribute(string accessKey, string attribute, string searchString) {
            object[] results = this.Invoke("FindByAttribute", new object[] {
                        accessKey,
                        attribute,
                        searchString});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void FindByAttributeAsync(string accessKey, string attribute, string searchString) {
            this.FindByAttributeAsync(accessKey, attribute, searchString, null);
        }
        
        /// <remarks/>
        public void FindByAttributeAsync(string accessKey, string attribute, string searchString, object userState) {
            if ((this.FindByAttributeOperationCompleted == null)) {
                this.FindByAttributeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindByAttributeOperationCompleted);
            }
            this.InvokeAsync("FindByAttribute", new object[] {
                        accessKey,
                        attribute,
                        searchString}, this.FindByAttributeOperationCompleted, userState);
        }
        
        private void OnFindByAttributeOperationCompleted(object arg) {
            if ((this.FindByAttributeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindByAttributeCompleted(this, new FindByAttributeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/FindByAttributeAndObjectClass" +
            "", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] FindByAttributeAndObjectClass(string accessKey, string attribute, string objectClass, string searchString) {
            object[] results = this.Invoke("FindByAttributeAndObjectClass", new object[] {
                        accessKey,
                        attribute,
                        objectClass,
                        searchString});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void FindByAttributeAndObjectClassAsync(string accessKey, string attribute, string objectClass, string searchString) {
            this.FindByAttributeAndObjectClassAsync(accessKey, attribute, objectClass, searchString, null);
        }
        
        /// <remarks/>
        public void FindByAttributeAndObjectClassAsync(string accessKey, string attribute, string objectClass, string searchString, object userState) {
            if ((this.FindByAttributeAndObjectClassOperationCompleted == null)) {
                this.FindByAttributeAndObjectClassOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindByAttributeAndObjectClassOperationCompleted);
            }
            this.InvokeAsync("FindByAttributeAndObjectClass", new object[] {
                        accessKey,
                        attribute,
                        objectClass,
                        searchString}, this.FindByAttributeAndObjectClassOperationCompleted, userState);
        }
        
        private void OnFindByAttributeAndObjectClassOperationCompleted(object arg) {
            if ((this.FindByAttributeAndObjectClassCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindByAttributeAndObjectClassCompleted(this, new FindByAttributeAndObjectClassCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/FindUniqueByAttributeAndObjec" +
            "tClass", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] FindUniqueByAttributeAndObjectClass(string accessKey, string attribute, string objectClass, string searchString) {
            object[] results = this.Invoke("FindUniqueByAttributeAndObjectClass", new object[] {
                        accessKey,
                        attribute,
                        objectClass,
                        searchString});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void FindUniqueByAttributeAndObjectClassAsync(string accessKey, string attribute, string objectClass, string searchString) {
            this.FindUniqueByAttributeAndObjectClassAsync(accessKey, attribute, objectClass, searchString, null);
        }
        
        /// <remarks/>
        public void FindUniqueByAttributeAndObjectClassAsync(string accessKey, string attribute, string objectClass, string searchString, object userState) {
            if ((this.FindUniqueByAttributeAndObjectClassOperationCompleted == null)) {
                this.FindUniqueByAttributeAndObjectClassOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindUniqueByAttributeAndObjectClassOperationCompleted);
            }
            this.InvokeAsync("FindUniqueByAttributeAndObjectClass", new object[] {
                        accessKey,
                        attribute,
                        objectClass,
                        searchString}, this.FindUniqueByAttributeAndObjectClassOperationCompleted, userState);
        }
        
        private void OnFindUniqueByAttributeAndObjectClassOperationCompleted(object arg) {
            if ((this.FindUniqueByAttributeAndObjectClassCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindUniqueByAttributeAndObjectClassCompleted(this, new FindUniqueByAttributeAndObjectClassCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/SearchExt", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SearchExt(string accessKey, string queryDoc, string hitlistDoc) {
            object[] results = this.Invoke("SearchExt", new object[] {
                        accessKey,
                        queryDoc,
                        hitlistDoc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SearchExtAsync(string accessKey, string queryDoc, string hitlistDoc) {
            this.SearchExtAsync(accessKey, queryDoc, hitlistDoc, null);
        }
        
        /// <remarks/>
        public void SearchExtAsync(string accessKey, string queryDoc, string hitlistDoc, object userState) {
            if ((this.SearchExtOperationCompleted == null)) {
                this.SearchExtOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchExtOperationCompleted);
            }
            this.InvokeAsync("SearchExt", new object[] {
                        accessKey,
                        queryDoc,
                        hitlistDoc}, this.SearchExtOperationCompleted, userState);
        }
        
        private void OnSearchExtOperationCompleted(object arg) {
            if ((this.SearchExtCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchExtCompleted(this, new SearchExtCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/SearchExt2", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SearchExt2(string accessKey, string queryDoc, string hitlistDoc, string language) {
            object[] results = this.Invoke("SearchExt2", new object[] {
                        accessKey,
                        queryDoc,
                        hitlistDoc,
                        language});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SearchExt2Async(string accessKey, string queryDoc, string hitlistDoc, string language) {
            this.SearchExt2Async(accessKey, queryDoc, hitlistDoc, language, null);
        }
        
        /// <remarks/>
        public void SearchExt2Async(string accessKey, string queryDoc, string hitlistDoc, string language, object userState) {
            if ((this.SearchExt2OperationCompleted == null)) {
                this.SearchExt2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchExt2OperationCompleted);
            }
            this.InvokeAsync("SearchExt2", new object[] {
                        accessKey,
                        queryDoc,
                        hitlistDoc,
                        language}, this.SearchExt2OperationCompleted, userState);
        }
        
        private void OnSearchExt2OperationCompleted(object arg) {
            if ((this.SearchExt2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchExt2Completed(this, new SearchExt2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/SearchExt3", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SearchExt3(string accessKey, string queryDoc, string hitlistDoc, string language, bool returnNumberOfSegments) {
            object[] results = this.Invoke("SearchExt3", new object[] {
                        accessKey,
                        queryDoc,
                        hitlistDoc,
                        language,
                        returnNumberOfSegments});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SearchExt3Async(string accessKey, string queryDoc, string hitlistDoc, string language, bool returnNumberOfSegments) {
            this.SearchExt3Async(accessKey, queryDoc, hitlistDoc, language, returnNumberOfSegments, null);
        }
        
        /// <remarks/>
        public void SearchExt3Async(string accessKey, string queryDoc, string hitlistDoc, string language, bool returnNumberOfSegments, object userState) {
            if ((this.SearchExt3OperationCompleted == null)) {
                this.SearchExt3OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchExt3OperationCompleted);
            }
            this.InvokeAsync("SearchExt3", new object[] {
                        accessKey,
                        queryDoc,
                        hitlistDoc,
                        language,
                        returnNumberOfSegments}, this.SearchExt3OperationCompleted, userState);
        }
        
        private void OnSearchExt3OperationCompleted(object arg) {
            if ((this.SearchExt3Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchExt3Completed(this, new SearchExt3CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blue-order.com/ma/datamanagerws/dmsearch/SearchSegments", RequestNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", ResponseNamespace="http://www.blue-order.com/ma/datamanagerws/dmsearch", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SearchSegments(string accessKey, string dmguid, string mdclass, string queryDoc) {
            object[] results = this.Invoke("SearchSegments", new object[] {
                        accessKey,
                        dmguid,
                        mdclass,
                        queryDoc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SearchSegmentsAsync(string accessKey, string dmguid, string mdclass, string queryDoc) {
            this.SearchSegmentsAsync(accessKey, dmguid, mdclass, queryDoc, null);
        }
        
        /// <remarks/>
        public void SearchSegmentsAsync(string accessKey, string dmguid, string mdclass, string queryDoc, object userState) {
            if ((this.SearchSegmentsOperationCompleted == null)) {
                this.SearchSegmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchSegmentsOperationCompleted);
            }
            this.InvokeAsync("SearchSegments", new object[] {
                        accessKey,
                        dmguid,
                        mdclass,
                        queryDoc}, this.SearchSegmentsOperationCompleted, userState);
        }
        
        private void OnSearchSegmentsOperationCompleted(object arg) {
            if ((this.SearchSegmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchSegmentsCompleted(this, new SearchSegmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SearchCompletedEventHandler(object sender, SearchCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void Search2CompletedEventHandler(object sender, Search2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Search2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Search2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void FindByAttributeCompletedEventHandler(object sender, FindByAttributeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindByAttributeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindByAttributeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void FindByAttributeAndObjectClassCompletedEventHandler(object sender, FindByAttributeAndObjectClassCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindByAttributeAndObjectClassCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindByAttributeAndObjectClassCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void FindUniqueByAttributeAndObjectClassCompletedEventHandler(object sender, FindUniqueByAttributeAndObjectClassCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindUniqueByAttributeAndObjectClassCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindUniqueByAttributeAndObjectClassCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SearchExtCompletedEventHandler(object sender, SearchExtCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchExtCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchExtCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SearchExt2CompletedEventHandler(object sender, SearchExt2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchExt2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchExt2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SearchExt3CompletedEventHandler(object sender, SearchExt3CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchExt3CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchExt3CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SearchSegmentsCompletedEventHandler(object sender, SearchSegmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchSegmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchSegmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591