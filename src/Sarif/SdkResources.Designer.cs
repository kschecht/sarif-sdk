﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SdkResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SdkResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.SdkResources", typeof(SdkResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The check {0} detected a failure..
        /// </summary>
        internal static string AndroidStudioDescriptionUnknown {
            get {
                return ResourceManager.GetString("AndroidStudioDescriptionUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Android Studio input for entry point was missing FQNAME or TYPE..
        /// </summary>
        internal static string AndroidStudioEntryPointMissingRequiredData {
            get {
                return ResourceManager.GetString("AndroidStudioEntryPointMissingRequiredData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file name was not present in an Android Studio problem, even though a line number was present..
        /// </summary>
        internal static string AndroidStudioFileMissing {
            get {
                return ResourceManager.GetString("AndroidStudioFileMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Android Studio problem has no identifying location information..
        /// </summary>
        internal static string AndroidStudioHasNoLocationInformation {
            get {
                return ResourceManager.GetString("AndroidStudioHasNoLocationInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &quot;hint&quot; element was missing a value in an Android Studio log..
        /// </summary>
        internal static string AndroidStudioHintElementMissingValue {
            get {
                return ResourceManager.GetString("AndroidStudioHintElementMissingValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected the Hints element to contain only Hint elements, but another element was observed..
        /// </summary>
        internal static string AndroidStudioHintsElementContainedNonHint {
            get {
                return ResourceManager.GetString("AndroidStudioHintsElementContainedNonHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Possible resolution: {0}.
        /// </summary>
        internal static string AndroidStudioHintStaple {
            get {
                return ResourceManager.GetString("AndroidStudioHintStaple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a non-negative line number for Android Studio problem element..
        /// </summary>
        internal static string AndroidStudioInvalidLineNumber {
            get {
                return ResourceManager.GetString("AndroidStudioInvalidLineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to parse a Problem element, but some other data was present..
        /// </summary>
        internal static string AndroidStudioNotProblemElement {
            get {
                return ResourceManager.GetString("AndroidStudioNotProblemElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An AndroidStudio problem could not be created because required &quot;problem class&quot; element was missing..
        /// </summary>
        internal static string AndroidStudioProblemMissingProblemClass {
            get {
                return ResourceManager.GetString("AndroidStudioProblemMissingProblemClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The non-generic GetProperty method only works for properties that are JSON strings. To retrieve a property with any other .NET type, call the generic method GetProperty&lt;T&gt;(string propertyName), where T is the .NET type of the object stored in the specified property..
        /// </summary>
        internal static string CallGenericGetProperty {
            get {
                return ResourceManager.GetString("CallGenericGetProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To retrieve a property with a string value, call the non-generic GetProperty method..
        /// </summary>
        internal static string CallNonGenericGetProperty {
            get {
                return ResourceManager.GetString("CallNonGenericGetProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write result: Tool not yet written..
        /// </summary>
        internal static string CannotWriteResultToolMissing {
            get {
                return ResourceManager.GetString("CannotWriteResultToolMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CppCheck file did not start with &quot;results/cppcheck&quot; element with version information..
        /// </summary>
        internal static string CppCheckCppCheckElementMissing {
            get {
                return ResourceManager.GetString("CppCheckCppCheckElementMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not parse CppCheck error node; element name was not error..
        /// </summary>
        internal static string CppCheckElementNotError {
            get {
                return ResourceManager.GetString("CppCheckElementNotError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CppCheck file did not contain the errors element in the expected location..
        /// </summary>
        internal static string CppCheckErrorsElementMissing {
            get {
                return ResourceManager.GetString("CppCheckErrorsElementMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not parse CppCheck location node; element name was not &apos;location&apos;..
        /// </summary>
        internal static string CppCheckLocationElementNameIncorrect {
            get {
                return ResourceManager.GetString("CppCheckLocationElementNameIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} line {1}.
        /// </summary>
        internal static string CppCheckLocationFormat {
            get {
                return ResourceManager.GetString("CppCheckLocationFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The `line` attribute for a CppCheck &lt;location&gt; was not set..
        /// </summary>
        internal static string CppCheckLocationMissingLine {
            get {
                return ResourceManager.GetString("CppCheckLocationMissingLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The `file` attribute for a CppCheck &lt;location&gt; was not set..
        /// </summary>
        internal static string CppCheckLocationMissingName {
            get {
                return ResourceManager.GetString("CppCheckLocationMissingName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The `file` value for a CppCheckLocation was empty..
        /// </summary>
        internal static string CppCheckLocationNameEmpty {
            get {
                return ResourceManager.GetString("CppCheckLocationNameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The `line` value for a CppCheckLocation must be positive..
        /// </summary>
        internal static string CppCheckLocationNegativeLine {
            get {
                return ResourceManager.GetString("CppCheckLocationNegativeLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A CppCheck entry must have a nonzero number of locations..
        /// </summary>
        internal static string CppCheckMissingLocation {
            get {
                return ResourceManager.GetString("CppCheckMissingLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1}: error {2}: {3}.
        /// </summary>
        internal static string ERR1000_ParseError {
            get {
                return ResourceManager.GetString("ERR1000_ParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not access a file specified on the command line: &apos;{0}&apos;..
        /// </summary>
        internal static string ERR997_ExceptionAccessingFile {
            get {
                return ResourceManager.GetString("ERR997_ExceptionAccessingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create output file &apos;{0}&apos;..
        /// </summary>
        internal static string ERR997_ExceptionCreatingLogFile {
            get {
                return ResourceManager.GetString("ERR997_ExceptionCreatingLogFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not instantiate skimmers from the following plugins: {0}..
        /// </summary>
        internal static string ERR997_ExceptionInstantiatingSkimmers {
            get {
                return ResourceManager.GetString("ERR997_ExceptionInstantiatingSkimmers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load analysis target &apos;{0}&apos;..
        /// </summary>
        internal static string ERR997_ExceptionLoadingAnalysisTarget {
            get {
                return ResourceManager.GetString("ERR997_ExceptionLoadingAnalysisTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not evaluated for check &apos;{1}&apos; because its PDB could not be loaded..
        /// </summary>
        internal static string ERR997_ExceptionLoadingPdb {
            get {
                return ResourceManager.GetString("ERR997_ExceptionLoadingPdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load the plug-in &apos;{0}&apos;..
        /// </summary>
        internal static string ERR997_ExceptionLoadingPlugIn {
            get {
                return ResourceManager.GetString("ERR997_ExceptionLoadingPlugIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A required file specified on the command line could not be found: &apos;{0}&apos;..
        /// </summary>
        internal static string ERR997_MissingFile {
            get {
                return ResourceManager.GetString("ERR997_MissingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check &apos;{0}&apos; was disabled while analyzing &apos;{1}&apos; because the analysis was not configured with required policy ({2}). To resolve this, configure and provide a policy file on the {3} command-line using the --policy argument (recommended), or pass &apos;--config default&apos; to invoke built-in settings. Invoke the {3} &apos;exportConfig&apos; command to produce an initial configuration file that can be edited, if necessary, and passed back into the tool..
        /// </summary>
        internal static string ERR997_MissingRuleConfiguration {
            get {
                return ResourceManager.GetString("ERR997_MissingRuleConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not instantiate any analysis rules..
        /// </summary>
        internal static string ERR997_NoRulesLoaded {
            get {
                return ResourceManager.GetString("ERR997_NoRulesLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid analysis targets were specified..
        /// </summary>
        internal static string ERR997_NoValidAnalysisTargets {
            get {
                return ResourceManager.GetString("ERR997_NoValidAnalysisTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised analyzing &apos;{0}&apos; for check &apos;{1}&apos; (which has been disabled). The exception may have resulted from a problem related to parsing image metadata and not specific to the rule, however..
        /// </summary>
        internal static string ERR998_ExceptionInAnalyze {
            get {
                return ResourceManager.GetString("ERR998_ExceptionInAnalyze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised attempting to determine whether &apos;{0}&apos; is a valid analysis target for check &apos;{1}&apos; (which has been disabled). The exception may have resulted from a problem related to parsing the analysis target and not specific to the rule, however..
        /// </summary>
        internal static string ERR998_ExceptionInCanAnalyze {
            get {
                return ResourceManager.GetString("ERR998_ExceptionInCanAnalyze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised initializing check &apos;{0}&apos; (which has been disabled)..
        /// </summary>
        internal static string ERR998_ExceptionInInitialize {
            get {
                return ResourceManager.GetString("ERR998_ExceptionInInitialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised during analysis..
        /// </summary>
        internal static string ERR999_UnhandledEngineException {
            get {
                return ResourceManager.GetString("ERR999_UnhandledEngineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected to find an element named {0}..
        /// </summary>
        internal static string ExpectedElementNamed {
            get {
                return ResourceManager.GetString("ExpectedElementNamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fortify PathElement has non-positive line start value..
        /// </summary>
        internal static string FortifyBadLineNumber {
            get {
                return ResourceManager.GetString("FortifyBadLineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fortify failure in {0}..
        /// </summary>
        internal static string FortifyFallbackMessage {
            get {
                return ResourceManager.GetString("FortifyFallbackMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A node did not match the PathElement portion of the Fortify schema..
        /// </summary>
        internal static string FortifyNotValidPathElement {
            get {
                return ResourceManager.GetString("FortifyNotValidPathElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result did not match the Fortify schema..
        /// </summary>
        internal static string FortifyNotValidResult {
            get {
                return ResourceManager.GetString("FortifyNotValidResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element expected to be located under a different parent element..
        /// </summary>
        internal static string InvalidParentXml {
            get {
                return ResourceManager.GetString("InvalidParentXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more invalid states were detected during serialization. This indicates that logging methods were called in the wrong order: {0}.
        /// </summary>
        internal static string InvalidState {
            get {
                return ResourceManager.GetString("InvalidState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line number supplied was out of range [1, numberOfLinesInFile + 1).
        /// </summary>
        internal static string LineNumberWasOutOfRange {
            get {
                return ResourceManager.GetString("LineNumberWasOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis completed successfully..
        /// </summary>
        internal static string MSG_AnalysisCompletedSuccessfully {
            get {
                return ResourceManager.GetString("MSG_AnalysisCompletedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis finished but was not complete due to non-fatal runtime errors..
        /// </summary>
        internal static string MSG_AnalysisIncomplete {
            get {
                return ResourceManager.GetString("MSG_AnalysisIncomplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzing....
        /// </summary>
        internal static string MSG_Analyzing {
            get {
                return ResourceManager.GetString("MSG_Analyzing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis halted prematurely due to a fatal execution condition..
        /// </summary>
        internal static string MSG_UnexpectedApplicationExit {
            get {
                return ResourceManager.GetString("MSG_UnexpectedApplicationExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzing &apos;{0}&apos;....
        /// </summary>
        internal static string MSG001_AnalyzingTarget {
            get {
                return ResourceManager.GetString("MSG001_AnalyzingTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not evaluated for check &apos;{1}&apos; as the analysis is not relevant based on observed metadata: {2}..
        /// </summary>
        internal static string NotApplicable_InvalidMetadata {
            get {
                return ResourceManager.GetString("NotApplicable_InvalidMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; does not exist. Consider calling TryGetProperty instead..
        /// </summary>
        internal static string PropertyDoesNotExist {
            get {
                return ResourceManager.GetString("PropertyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object cannot be serialized until results serialization is completed..
        /// </summary>
        internal static string ResultsSerializationNotComplete {
            get {
                return ResourceManager.GetString("ResultsSerializationNotComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run has already been written. It cannot be written again..
        /// </summary>
        internal static string RunAlreadyWritten {
            get {
                return ResourceManager.GetString("RunAlreadyWritten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;uri&apos; member of &apos;{0}&apos; instance is not valid: &apos;{1}&apos;.
        /// </summary>
        internal static string SARIF001_InvalidUri {
            get {
                return ResourceManager.GetString("SARIF001_InvalidUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tool has already been written. It cannot be written again..
        /// </summary>
        internal static string ToolAlreadyWritten {
            get {
                return ResourceManager.GetString("ToolAlreadyWritten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value cannot be negative..
        /// </summary>
        internal static string ValueCannotBeNegative {
            get {
                return ResourceManager.GetString("ValueCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be greater than or equal to 1..
        /// </summary>
        internal static string ValueMustBeAtLeastOne {
            get {
                return ResourceManager.GetString("ValueMustBeAtLeastOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not analyzed as it does not appear to be a valid file type for analysis..
        /// </summary>
        internal static string WRN997_InvalidTarget {
            get {
                return ResourceManager.GetString("WRN997_InvalidTarget", resourceCulture);
            }
        }
    }
}
