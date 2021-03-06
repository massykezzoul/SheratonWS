//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace AganceDeVoyage.Hotel {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="HotelSoap", Namespace="http://tempuri.org/")]
    public partial class Hotel : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getDisponibleOperationCompleted;
        
        private System.Threading.SendOrPostCallback reserverOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Hotel() {
            this.Url = global::AganceDeVoyage.Properties.Settings.Default.AganceDeVoyage_Hotel_Hotel;
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
        public event getDisponibleCompletedEventHandler getDisponibleCompleted;
        
        /// <remarks/>
        public event reserverCompletedEventHandler reserverCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDisponible", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SOAPResponse getDisponible(string agence, string aPwd, System.DateTime debut, System.DateTime fin, int nbPersonnes) {
            object[] results = this.Invoke("getDisponible", new object[] {
                        agence,
                        aPwd,
                        debut,
                        fin,
                        nbPersonnes});
            return ((SOAPResponse)(results[0]));
        }
        
        /// <remarks/>
        public void getDisponibleAsync(string agence, string aPwd, System.DateTime debut, System.DateTime fin, int nbPersonnes) {
            this.getDisponibleAsync(agence, aPwd, debut, fin, nbPersonnes, null);
        }
        
        /// <remarks/>
        public void getDisponibleAsync(string agence, string aPwd, System.DateTime debut, System.DateTime fin, int nbPersonnes, object userState) {
            if ((this.getDisponibleOperationCompleted == null)) {
                this.getDisponibleOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDisponibleOperationCompleted);
            }
            this.InvokeAsync("getDisponible", new object[] {
                        agence,
                        aPwd,
                        debut,
                        fin,
                        nbPersonnes}, this.getDisponibleOperationCompleted, userState);
        }
        
        private void OngetDisponibleOperationCompleted(object arg) {
            if ((this.getDisponibleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDisponibleCompleted(this, new getDisponibleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/reserver", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SOAPResponse reserver(string agence, string aPwd, string idChambre, System.DateTime debut, System.DateTime fin, int nbPersonnes, string nom, string prenom) {
            object[] results = this.Invoke("reserver", new object[] {
                        agence,
                        aPwd,
                        idChambre,
                        debut,
                        fin,
                        nbPersonnes,
                        nom,
                        prenom});
            return ((SOAPResponse)(results[0]));
        }
        
        /// <remarks/>
        public void reserverAsync(string agence, string aPwd, string idChambre, System.DateTime debut, System.DateTime fin, int nbPersonnes, string nom, string prenom) {
            this.reserverAsync(agence, aPwd, idChambre, debut, fin, nbPersonnes, nom, prenom, null);
        }
        
        /// <remarks/>
        public void reserverAsync(string agence, string aPwd, string idChambre, System.DateTime debut, System.DateTime fin, int nbPersonnes, string nom, string prenom, object userState) {
            if ((this.reserverOperationCompleted == null)) {
                this.reserverOperationCompleted = new System.Threading.SendOrPostCallback(this.OnreserverOperationCompleted);
            }
            this.InvokeAsync("reserver", new object[] {
                        agence,
                        aPwd,
                        idChambre,
                        debut,
                        fin,
                        nbPersonnes,
                        nom,
                        prenom}, this.reserverOperationCompleted, userState);
        }
        
        private void OnreserverOperationCompleted(object arg) {
            if ((this.reserverCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.reserverCompleted(this, new reserverCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SOAPResponse {
        
        private bool successField;
        
        private string messageField;
        
        private string agenceField;
        
        private Offre[] resultField;
        
        /// <remarks/>
        public bool success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public string agence {
            get {
                return this.agenceField;
            }
            set {
                this.agenceField = value;
            }
        }
        
        /// <remarks/>
        public Offre[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Offre {
        
        private string hotelField;
        
        private string nomOffreField;
        
        private int litsField;
        
        private double prixField;
        
        /// <remarks/>
        public string hotel {
            get {
                return this.hotelField;
            }
            set {
                this.hotelField = value;
            }
        }
        
        /// <remarks/>
        public string nomOffre {
            get {
                return this.nomOffreField;
            }
            set {
                this.nomOffreField = value;
            }
        }
        
        /// <remarks/>
        public int lits {
            get {
                return this.litsField;
            }
            set {
                this.litsField = value;
            }
        }
        
        /// <remarks/>
        public double prix {
            get {
                return this.prixField;
            }
            set {
                this.prixField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getDisponibleCompletedEventHandler(object sender, getDisponibleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDisponibleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDisponibleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SOAPResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SOAPResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void reserverCompletedEventHandler(object sender, reserverCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class reserverCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal reserverCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SOAPResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SOAPResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591