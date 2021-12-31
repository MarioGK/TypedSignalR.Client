// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TypedSignalR.Client.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ExtensionsTemplate : ExtensionsTemplateBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("// <auto-generated>\r\n// THIS (.cs) FILE IS GENERATED BY TypedSignalR.Client\r\n// <" +
                    "/auto-generated>\r\nnamespace TypedSignalR.Client\r\n{\r\n    public interface IHubCon" +
                    "nectionObserver\r\n    {\r\n        System.Threading.Tasks.Task OnClosed(System.Exce" +
                    "ption e);\r\n        System.Threading.Tasks.Task OnReconnected(string connectionId" +
                    ");\r\n        System.Threading.Tasks.Task OnReconnecting(System.Exception e);\r\n   " +
                    " }\r\n\r\n    public static partial class Extensions\r\n    {\r\n        private static " +
                    "class HubInvokerConstructorCache<T>\r\n        {\r\n#pragma warning disable CS0649\r\n" +
                    "            public static System.Func<Microsoft.AspNetCore.SignalR.Client.HubCon" +
                    "nection, System.Threading.CancellationToken, T> Construct;\r\n#pragma warning rest" +
                    "ore CS0649\r\n        }\r\n\r\n        private static class ReceiverBinderCache<T>\r\n  " +
                    "      {\r\n#pragma warning disable CS0649\r\n            public static System.Func<M" +
                    "icrosoft.AspNetCore.SignalR.Client.HubConnection, T, CompositeDisposable> Bind;\r" +
                    "\n#pragma warning restore CS0649\r\n        }\r\n\r\n        public static THub CreateH" +
                    "ubProxy<THub>(this Microsoft.AspNetCore.SignalR.Client.HubConnection connection," +
                    " System.Threading.CancellationToken cancellationToken = default)\r\n        {\r\n   " +
                    "         return connection.CreateHubProxyCore<THub>(cancellationToken);\r\n       " +
                    " }\r\n\r\n        public static System.IDisposable Register<TReceiver>(this Microsof" +
                    "t.AspNetCore.SignalR.Client.HubConnection connection, TReceiver receiver)\r\n     " +
                    "   {\r\n            return connection.RegisterCore<TReceiver>(receiver);\r\n        " +
                    "}\r\n\r\n        private static THub CreateHubProxyCore<THub>(this Microsoft.AspNetC" +
                    "ore.SignalR.Client.HubConnection connection, System.Threading.CancellationToken " +
                    "cancellationToken)\r\n        {\r\n            return HubInvokerConstructorCache<THu" +
                    "b>.Construct(connection, cancellationToken);\r\n        }\r\n\r\n        private stati" +
                    "c System.IDisposable RegisterCore<TReceiver>(this Microsoft.AspNetCore.SignalR.C" +
                    "lient.HubConnection connection, TReceiver receiver)\r\n        {\r\n            if (" +
                    "typeof(TReceiver) == typeof(IHubConnectionObserver))\r\n            {\r\n           " +
                    "     return new HubConnectionObserverSubscription(connection, receiver as IHubCo" +
                    "nnectionObserver);\r\n            }\r\n\r\n            var compositeDisposable = Recei" +
                    "verBinderCache<TReceiver>.Bind(connection, receiver);\r\n\r\n            if (receive" +
                    "r is IHubConnectionObserver hubConnectionObserver)\r\n            {\r\n             " +
                    "   var subscription = new HubConnectionObserverSubscription(connection, hubConne" +
                    "ctionObserver);\r\n                compositeDisposable.Add(subscription);\r\n       " +
                    "     }\r\n\r\n            return compositeDisposable;\r\n        }\r\n\r\n        private " +
                    "sealed class CompositeDisposable : System.IDisposable\r\n        {\r\n            pr" +
                    "ivate readonly object _gate = new();\r\n            private readonly System.Collec" +
                    "tions.Generic.List<System.IDisposable> _disposables;\r\n\r\n            private bool" +
                    " _disposed;\r\n\r\n            public CompositeDisposable()\r\n            {\r\n        " +
                    "        _disposables = new System.Collections.Generic.List<System.IDisposable>()" +
                    ";\r\n            }\r\n\r\n            public CompositeDisposable(int capacity)\r\n      " +
                    "      {\r\n                if (capacity < 0)\r\n                {\r\n                 " +
                    "   throw new System.ArgumentOutOfRangeException(nameof(capacity));\r\n            " +
                    "    }\r\n\r\n                _disposables = new System.Collections.Generic.List<Syst" +
                    "em.IDisposable>(capacity);\r\n            }\r\n\r\n            public void Add(System." +
                    "IDisposable item)\r\n            {\r\n                var shouldDispose = false;\r\n\r\n" +
                    "                lock (_gate)\r\n                {\r\n                    shouldDispo" +
                    "se = _disposed;\r\n\r\n                    if (!_disposed)\r\n                    {\r\n " +
                    "                       _disposables.Add(item);\r\n                    }\r\n         " +
                    "       }\r\n\r\n                if (shouldDispose)\r\n                {\r\n             " +
                    "       item.Dispose();\r\n                }\r\n            }\r\n\r\n            public v" +
                    "oid Dispose()\r\n            {\r\n                var currentDisposables = default(S" +
                    "ystem.Collections.Generic.List<System.IDisposable>);\r\n\r\n                lock (_g" +
                    "ate)\r\n                {\r\n                    if (!_disposed)\r\n                  " +
                    "  {\r\n                        _disposed = true;\r\n                        currentD" +
                    "isposables = _disposables;\r\n                    }\r\n                }\r\n\r\n        " +
                    "        if (currentDisposables is not null)\r\n                {\r\n                " +
                    "    foreach (var item in currentDisposables)\r\n                    {\r\n           " +
                    "             if (item is not null)\r\n                        {\r\n                 " +
                    "           item.Dispose();\r\n                        }\r\n                    }\r\n\r\n" +
                    "                    currentDisposables.Clear();\r\n                }\r\n            " +
                    "}\r\n        }\r\n\r\n        private class HubConnectionObserverSubscription : System" +
                    ".IDisposable\r\n        {\r\n            private readonly Microsoft.AspNetCore.Signa" +
                    "lR.Client.HubConnection _connection;\r\n            private readonly IHubConnectio" +
                    "nObserver _hubConnectionEvent;\r\n\r\n            public HubConnectionObserverSubscr" +
                    "iption(Microsoft.AspNetCore.SignalR.Client.HubConnection connection, IHubConnect" +
                    "ionObserver hubConnectionEvent)\r\n            {\r\n                _connection = co" +
                    "nnection;\r\n                _hubConnectionEvent = hubConnectionEvent;\r\n          " +
                    "      _connection.Closed += _hubConnectionEvent.OnClosed;\r\n                _conn" +
                    "ection.Reconnected += _hubConnectionEvent.OnReconnected;\r\n                _conne" +
                    "ction.Reconnecting += _hubConnectionEvent.OnReconnecting;\r\n            }\r\n\r\n    " +
                    "        public void Dispose()\r\n            {\r\n                _connection.Closed" +
                    " -= _hubConnectionEvent.OnClosed;\r\n                _connection.Reconnected -= _h" +
                    "ubConnectionEvent.OnReconnected;\r\n                _connection.Reconnecting -= _h" +
                    "ubConnectionEvent.OnReconnecting;\r\n            }\r\n        }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class ExtensionsTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
