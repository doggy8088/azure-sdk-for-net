// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Run notebook response. </summary>
    public partial class RunNotebookResponse
    {
        /// <summary> Initializes a new instance of RunNotebookResponse. </summary>
        internal RunNotebookResponse()
        {
        }

        /// <summary> Initializes a new instance of RunNotebookResponse. </summary>
        /// <param name="message"> Response message. </param>
        /// <param name="result"> Result of run notebook. </param>
        internal RunNotebookResponse(string message, RunNotebookResult result)
        {
            Message = message;
            Result = result;
        }

        /// <summary> Response message. </summary>
        public string Message { get; }
        /// <summary> Result of run notebook. </summary>
        public RunNotebookResult Result { get; }
    }
}
