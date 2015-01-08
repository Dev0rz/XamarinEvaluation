//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34014
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDCParameters.MockService {
    
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="EDCParameters.MockService", ConfigurationName="IMockService")]
public interface IMockService {
    
    // CODEGEN: Der Nachrichtenvertrag wird generiert, da der Wrappernamespace (http://tempuri.org/) von Nachricht "GetRouteOperationsRequest" nicht mit dem Standardwert (EDCParameters.MockService) übereinstimmt.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMockService/GetRouteOperations", ReplyAction="http://tempuri.org/IMockService/GetRouteOperationsResponse")]
    GetRouteOperationsResponse GetRouteOperations(GetRouteOperationsRequest request);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMockService/GetRouteOperations", ReplyAction="http://tempuri.org/IMockService/GetRouteOperationsResponse")]
    System.IAsyncResult BeginGetRouteOperations(GetRouteOperationsRequest request, System.AsyncCallback callback, object asyncState);
    
    GetRouteOperationsResponse EndGetRouteOperations(System.IAsyncResult result);
    
    // CODEGEN: Der Nachrichtenvertrag wird generiert, da der Wrappernamespace (http://tempuri.org/) von Nachricht "IsValidUserRequest" nicht mit dem Standardwert (EDCParameters.MockService) übereinstimmt.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMockService/IsValidUser", ReplyAction="http://tempuri.org/IMockService/IsValidUserResponse")]
    IsValidUserResponse IsValidUser(IsValidUserRequest request);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMockService/IsValidUser", ReplyAction="http://tempuri.org/IMockService/IsValidUserResponse")]
    System.IAsyncResult BeginIsValidUser(IsValidUserRequest request, System.AsyncCallback callback, object asyncState);
    
    IsValidUserResponse EndIsValidUser(System.IAsyncResult result);
    
    // CODEGEN: Der Nachrichtenvertrag wird generiert, da der Wrappernamespace (http://tempuri.org/) von Nachricht "EDC_GetParametersRequest" nicht mit dem Standardwert (EDCParameters.MockService) übereinstimmt.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMockService/EDC_GetParameters", ReplyAction="http://tempuri.org/IMockService/EDC_GetParametersResponse")]
    EDC_GetParametersResponse EDC_GetParameters(EDC_GetParametersRequest request);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMockService/EDC_GetParameters", ReplyAction="http://tempuri.org/IMockService/EDC_GetParametersResponse")]
    System.IAsyncResult BeginEDC_GetParameters(EDC_GetParametersRequest request, System.AsyncCallback callback, object asyncState);
    
    EDC_GetParametersResponse EndEDC_GetParameters(System.IAsyncResult result);
    
    // CODEGEN: Der Nachrichtenvertrag wird generiert, da der Wrappernamespace (http://tempuri.org/) von Nachricht "EDC_GetValuesRequest" nicht mit dem Standardwert (EDCParameters.MockService) übereinstimmt.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMockService/EDC_GetValues", ReplyAction="http://tempuri.org/IMockService/EDC_GetValuesResponse")]
    EDC_GetValuesResponse EDC_GetValues(EDC_GetValuesRequest request);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMockService/EDC_GetValues", ReplyAction="http://tempuri.org/IMockService/EDC_GetValuesResponse")]
    System.IAsyncResult BeginEDC_GetValues(EDC_GetValuesRequest request, System.AsyncCallback callback, object asyncState);
    
    EDC_GetValuesResponse EndEDC_GetValues(System.IAsyncResult result);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetRouteOperations", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetRouteOperationsRequest {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public string lotNumber;
    
    public GetRouteOperationsRequest() {
    }
    
    public GetRouteOperationsRequest(string lotNumber) {
        this.lotNumber = lotNumber;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetRouteOperationsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetRouteOperationsResponse {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public App.Mock.WebService.RouteOperation[] GetRouteOperationsResult;
    
    public GetRouteOperationsResponse() {
    }
    
    public GetRouteOperationsResponse(App.Mock.WebService.RouteOperation[] GetRouteOperationsResult) {
        this.GetRouteOperationsResult = GetRouteOperationsResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="IsValidUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class IsValidUserRequest {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public string Username;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
    public string Password;
    
    public IsValidUserRequest() {
    }
    
    public IsValidUserRequest(string Username, string Password) {
        this.Username = Username;
        this.Password = Password;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="IsValidUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class IsValidUserResponse {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public bool IsValidUserResult;
    
    public IsValidUserResponse() {
    }
    
    public IsValidUserResponse(bool IsValidUserResult) {
        this.IsValidUserResult = IsValidUserResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="EDC_GetParameters", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class EDC_GetParametersRequest {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public string lotNumber;
    
    public EDC_GetParametersRequest() {
    }
    
    public EDC_GetParametersRequest(string lotNumber) {
        this.lotNumber = lotNumber;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="EDC_GetParametersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class EDC_GetParametersResponse {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public System.Collections.Generic.KeyValuePairOfintstring[] EDC_GetParametersResult;
    
    public EDC_GetParametersResponse() {
    }
    
    public EDC_GetParametersResponse(System.Collections.Generic.KeyValuePairOfintstring[] EDC_GetParametersResult) {
        this.EDC_GetParametersResult = EDC_GetParametersResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="EDC_GetValues", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class EDC_GetValuesRequest {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public string lotNumber;
    
    public EDC_GetValuesRequest() {
    }
    
    public EDC_GetValuesRequest(string lotNumber) {
        this.lotNumber = lotNumber;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="EDC_GetValuesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class EDC_GetValuesResponse {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public System.Collections.Generic.KeyValuePairOfintstring[] EDC_GetValuesResult;
    
    public EDC_GetValuesResponse() {
    }
    
    public EDC_GetValuesResponse(System.Collections.Generic.KeyValuePairOfintstring[] EDC_GetValuesResult) {
        this.EDC_GetValuesResult = EDC_GetValuesResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMockServiceChannel : IMockService, System.ServiceModel.IClientChannel {
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MockServiceClient : System.ServiceModel.ClientBase<IMockService>, IMockService {
    
    public MockServiceClient() {
    }
    
    public MockServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
    }
    
    public MockServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public MockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public MockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress) {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetRouteOperationsResponse IMockService.GetRouteOperations(GetRouteOperationsRequest request) {
        return base.Channel.GetRouteOperations(request);
    }
    
    public App.Mock.WebService.RouteOperation[] GetRouteOperations(string lotNumber) {
        GetRouteOperationsRequest inValue = new GetRouteOperationsRequest();
        inValue.lotNumber = lotNumber;
        GetRouteOperationsResponse retVal = ((IMockService)(this)).GetRouteOperations(inValue);
        return retVal.GetRouteOperationsResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMockService.BeginGetRouteOperations(GetRouteOperationsRequest request, System.AsyncCallback callback, object asyncState) {
        return base.Channel.BeginGetRouteOperations(request, callback, asyncState);
    }
    
    public System.IAsyncResult BeginGetRouteOperations(string lotNumber, System.AsyncCallback callback, object asyncState) {
        GetRouteOperationsRequest inValue = new GetRouteOperationsRequest();
        inValue.lotNumber = lotNumber;
        return ((IMockService)(this)).BeginGetRouteOperations(inValue, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetRouteOperationsResponse IMockService.EndGetRouteOperations(System.IAsyncResult result) {
        return base.Channel.EndGetRouteOperations(result);
    }
    
    public App.Mock.WebService.RouteOperation[] EndGetRouteOperations(System.IAsyncResult result) {
        GetRouteOperationsResponse retVal = ((IMockService)(this)).EndGetRouteOperations(result);
        return retVal.GetRouteOperationsResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    IsValidUserResponse IMockService.IsValidUser(IsValidUserRequest request) {
        return base.Channel.IsValidUser(request);
    }
    
    public bool IsValidUser(string Username, string Password) {
        IsValidUserRequest inValue = new IsValidUserRequest();
        inValue.Username = Username;
        inValue.Password = Password;
        IsValidUserResponse retVal = ((IMockService)(this)).IsValidUser(inValue);
        return retVal.IsValidUserResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMockService.BeginIsValidUser(IsValidUserRequest request, System.AsyncCallback callback, object asyncState) {
        return base.Channel.BeginIsValidUser(request, callback, asyncState);
    }
    
    public System.IAsyncResult BeginIsValidUser(string Username, string Password, System.AsyncCallback callback, object asyncState) {
        IsValidUserRequest inValue = new IsValidUserRequest();
        inValue.Username = Username;
        inValue.Password = Password;
        return ((IMockService)(this)).BeginIsValidUser(inValue, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    IsValidUserResponse IMockService.EndIsValidUser(System.IAsyncResult result) {
        return base.Channel.EndIsValidUser(result);
    }
    
    public bool EndIsValidUser(System.IAsyncResult result) {
        IsValidUserResponse retVal = ((IMockService)(this)).EndIsValidUser(result);
        return retVal.IsValidUserResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    EDC_GetParametersResponse IMockService.EDC_GetParameters(EDC_GetParametersRequest request) {
        return base.Channel.EDC_GetParameters(request);
    }
    
    public System.Collections.Generic.KeyValuePairOfintstring[] EDC_GetParameters(string lotNumber) {
        EDC_GetParametersRequest inValue = new EDC_GetParametersRequest();
        inValue.lotNumber = lotNumber;
        EDC_GetParametersResponse retVal = ((IMockService)(this)).EDC_GetParameters(inValue);
        return retVal.EDC_GetParametersResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMockService.BeginEDC_GetParameters(EDC_GetParametersRequest request, System.AsyncCallback callback, object asyncState) {
        return base.Channel.BeginEDC_GetParameters(request, callback, asyncState);
    }
    
    public System.IAsyncResult BeginEDC_GetParameters(string lotNumber, System.AsyncCallback callback, object asyncState) {
        EDC_GetParametersRequest inValue = new EDC_GetParametersRequest();
        inValue.lotNumber = lotNumber;
        return ((IMockService)(this)).BeginEDC_GetParameters(inValue, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    EDC_GetParametersResponse IMockService.EndEDC_GetParameters(System.IAsyncResult result) {
        return base.Channel.EndEDC_GetParameters(result);
    }
    
    public System.Collections.Generic.KeyValuePairOfintstring[] EndEDC_GetParameters(System.IAsyncResult result) {
        EDC_GetParametersResponse retVal = ((IMockService)(this)).EndEDC_GetParameters(result);
        return retVal.EDC_GetParametersResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    EDC_GetValuesResponse IMockService.EDC_GetValues(EDC_GetValuesRequest request) {
        return base.Channel.EDC_GetValues(request);
    }
    
    public System.Collections.Generic.KeyValuePairOfintstring[] EDC_GetValues(string lotNumber) {
        EDC_GetValuesRequest inValue = new EDC_GetValuesRequest();
        inValue.lotNumber = lotNumber;
        EDC_GetValuesResponse retVal = ((IMockService)(this)).EDC_GetValues(inValue);
        return retVal.EDC_GetValuesResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMockService.BeginEDC_GetValues(EDC_GetValuesRequest request, System.AsyncCallback callback, object asyncState) {
        return base.Channel.BeginEDC_GetValues(request, callback, asyncState);
    }
    
    public System.IAsyncResult BeginEDC_GetValues(string lotNumber, System.AsyncCallback callback, object asyncState) {
        EDC_GetValuesRequest inValue = new EDC_GetValuesRequest();
        inValue.lotNumber = lotNumber;
        return ((IMockService)(this)).BeginEDC_GetValues(inValue, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    EDC_GetValuesResponse IMockService.EndEDC_GetValues(System.IAsyncResult result) {
        return base.Channel.EndEDC_GetValues(result);
    }
    
    public System.Collections.Generic.KeyValuePairOfintstring[] EndEDC_GetValues(System.IAsyncResult result) {
        EDC_GetValuesResponse retVal = ((IMockService)(this)).EndEDC_GetValues(result);
        return retVal.EDC_GetValuesResult;
    }
}
namespace App.Mock.WebService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RouteOperation", Namespace="http://schemas.datacontract.org/2004/07/App.Mock.WebService")]
    public partial class RouteOperation : object, System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CT_PlanField;
        
        private string CT_QField;
        
        private string ColorField;
        
        private string Manufacturing_LineField;
        
        private string OpField;
        
        private string Op_SeqField;
        
        private string PlantField;
        
        private string PositionField;
        
        private string ProductField;
        
        private string Product_TypeField;
        
        private string Production_LevelField;
        
        private string RPTField;
        
        private string RouteField;
        
        private string TypeField;
        
        private string VersionField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CT_Plan {
            get {
                return this.CT_PlanField;
            }
            set {
                this.CT_PlanField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CT_Q {
            get {
                return this.CT_QField;
            }
            set {
                this.CT_QField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                this.ColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Manufacturing_Line {
            get {
                return this.Manufacturing_LineField;
            }
            set {
                this.Manufacturing_LineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Op {
            get {
                return this.OpField;
            }
            set {
                this.OpField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Op_Seq {
            get {
                return this.Op_SeqField;
            }
            set {
                this.Op_SeqField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Plant {
            get {
                return this.PlantField;
            }
            set {
                this.PlantField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                this.PositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Product {
            get {
                return this.ProductField;
            }
            set {
                this.ProductField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Product_Type {
            get {
                return this.Product_TypeField;
            }
            set {
                this.Product_TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Production_Level {
            get {
                return this.Production_LevelField;
            }
            set {
                this.Production_LevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RPT {
            get {
                return this.RPTField;
            }
            set {
                this.RPTField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Route {
            get {
                return this.RouteField;
            }
            set {
                this.RouteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version {
            get {
                return this.VersionField;
            }
            set {
                this.VersionField = value;
            }
        }
    }
}
namespace System.Collections.Generic {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KeyValuePairOfintstring", Namespace="http://schemas.datacontract.org/2004/07/System.Collections.Generic")]
    public partial struct KeyValuePairOfintstring : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int keyField;
        
        private string valueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}