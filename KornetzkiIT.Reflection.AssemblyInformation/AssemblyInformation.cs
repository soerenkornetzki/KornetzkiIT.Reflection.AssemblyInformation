using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

namespace KornetzkiIT.Reflection.AssemblyInformation
{
    /// <summary>
    /// A .NET Standard class for quering common assembly attributes out of an specified assembly.
    /// </summary>
    public class AssemblyInformation
    {
        #region Static Properties

        /// <summary>
        /// Returns an initialized instance of the <see cref="AssemblyInformation"/>
        /// </summary>
        public static AssemblyInformation EntryAssembly { get; } = new AssemblyInformation(Assembly.GetEntryAssembly());

        #endregion

        #region Class Properties

        /// <summary>
        /// The specified target assembly.
        /// </summary>
        /// <seealso cref="Assembly"/>
        public Assembly TargetAssembly { get; }

        /// <summary>
        /// Gets a Guid that represents the target assembly <see cref="GuidAttribute"/>.
        /// </summary>
        public Guid? Guid { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyProductAttribute"/>.
        /// </summary>
        public string Product { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyTitleAttribute"/>.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyDescriptionAttribute"/>.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyCompanyAttribute"/>.
        /// </summary>
        public string Company { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyCopyrightAttribute"/>.
        /// </summary>
        public string Copyright { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyTrademarkAttribute"/>.
        /// </summary>
        public string Trademark { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyConfigurationAttribute"/>.
        /// </summary>
        public string Configuration { get; }

        /// <summary>
        /// Gets a CultureInfo that represents the target assembly <see cref="AssemblyCultureAttribute"/>.
        /// </summary>
        public CultureInfo Culture { get; }

        /// <summary>
        /// Gets a CultureInfo that represents the target assembly <see cref="NeutralResourcesLanguageAttribute"/>.
        /// </summary>
        public CultureInfo NeutralResourcesLanguage { get; }

        /// <summary>
        /// Gets a boolean that represents the target assembly <see cref="ComVisibleAttribute"/>.
        /// </summary>
        public bool? ComVisible { get; }

        /// <summary>
        /// Gets a boolean that represents the target assembly <see cref="CLSCompliantAttribute"/>.
        /// </summary>
        public bool? CLSCompliant { get; }

        /// <summary>
        /// Gets a <see cref="System.Version"/> that represents the target assembly <see cref="AssemblyVersionAttribute"/>.
        /// </summary>
        public Version Version { get; }

        /// <summary>
        /// Gets a <see cref="System.Version"/> that represents the target assembly <see cref="AssemblyFileVersionAttribute"/>.
        /// </summary>
        public Version FileVersion { get; }

        /// <summary>
        /// Gets a string that represents the target assembly <see cref="AssemblyInformationalVersionAttribute"/>.
        /// </summary>
        /// <remarks>Returns <c>null</c> when the attribute could not be determined.</remarks>
        public string InformationalVersion { get; }

        #endregion

        #region Class Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyInformation"/>
        /// class with the target assembly being the calling assembly.
        /// </summary>
        /// <seealso cref="AssemblyInformation(Assembly)"/>
        public AssemblyInformation() : this(Assembly.GetCallingAssembly()) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyInformation"/>
        /// class with a specified target assembly.
        /// </summary>
        /// <param name="assembly">The specified target assembly.</param>
        public AssemblyInformation(Assembly assembly)
        {
            TargetAssembly = assembly ?? throw new ArgumentNullException("assembly");

            try { Guid = System.Guid.Parse(((GuidAttribute)TargetAssembly.GetCustomAttribute(typeof(GuidAttribute))).Value); }
            catch (Exception e)
            {
                Guid = null;
                Debug.WriteLine(string.Format("Could not extract GuidAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract GuidAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Product = ((AssemblyProductAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyProductAttribute))).Product; }
            catch (Exception e)
            {
                Product = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyProductAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyProductAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Title = ((AssemblyTitleAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyTitleAttribute))).Title; }
            catch (Exception e)
            {
                Title = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyTitleAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyTitleAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Description = ((AssemblyDescriptionAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyDescriptionAttribute))).Description; }
            catch (Exception e)
            {
                Description = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyDescriptionAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyDescriptionAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Company = ((AssemblyCompanyAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyCompanyAttribute))).Company; }
            catch (Exception e)
            {
                Company = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyCompanyAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyCompanyAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Copyright = ((AssemblyCopyrightAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyCopyrightAttribute))).Copyright; }
            catch (Exception e)
            {
                Copyright = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyCopyrightAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyCopyrightAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Trademark = ((AssemblyTrademarkAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyTrademarkAttribute))).Trademark; }
            catch (Exception e)
            {
                Trademark = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyTrademarkAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyTrademarkAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { Configuration = ((AssemblyConfigurationAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyConfigurationAttribute))).Configuration; }
            catch (Exception e)
            {
                Configuration = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyConfigurationAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyConfigurationAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try
            {
                string cultureString = ((AssemblyCultureAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyCultureAttribute))).Culture;
                if (string.IsNullOrWhiteSpace(cultureString))
                    Culture = null;
                else
                    Culture = new CultureInfo(cultureString);
            }
            catch (Exception e)
            {
                Culture = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyCultureAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyCultureAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try
            {
                string cultureString = ((NeutralResourcesLanguageAttribute)TargetAssembly.GetCustomAttribute(typeof(NeutralResourcesLanguageAttribute))).CultureName;
                if (string.IsNullOrWhiteSpace(cultureString))
                    NeutralResourcesLanguage = null;
                else
                    NeutralResourcesLanguage = new CultureInfo(cultureString);
            }
            catch (Exception e)
            {
                NeutralResourcesLanguage = null;
                Debug.WriteLine(string.Format("Could not extract NeutralResourcesLanguageAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract NeutralResourcesLanguageAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { ComVisible = ((ComVisibleAttribute)TargetAssembly.GetCustomAttribute(typeof(ComVisibleAttribute))).Value; }
            catch (Exception e)
            {
                ComVisible = null;
                Debug.WriteLine(string.Format("Could not extract ComVisibleAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract ComVisibleAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { CLSCompliant = ((CLSCompliantAttribute)TargetAssembly.GetCustomAttribute(typeof(CLSCompliantAttribute))).IsCompliant; }
            catch (Exception e)
            {
                CLSCompliant = null;
                Debug.WriteLine(string.Format("Could not extract CLSCompliantAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract CLSCompliantAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try
            {
                try { Version = System.Version.Parse(((AssemblyVersionAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyVersionAttribute))).Version); }
                catch { Version = TargetAssembly.GetName().Version; }
            }
            catch (Exception e)
            {
                Version = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyVersionAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyVersionAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { FileVersion = System.Version.Parse(((AssemblyFileVersionAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyFileVersionAttribute))).Version); }
            catch (Exception e)
            {
                FileVersion = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyFileVersionAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyFileVersionAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }

            try { InformationalVersion = ((AssemblyInformationalVersionAttribute)TargetAssembly.GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute))).InformationalVersion; }
            catch (Exception e)
            {
                InformationalVersion = null;
                Debug.WriteLine(string.Format("Could not extract AssemblyInformationalVersionAttribute: {0} {1}", e.GetType().ToString(), e.Message), e.StackTrace);
                Trace.TraceWarning("Could not extract AssemblyInformationalVersionAttribute: {0} {1}", e.GetType().ToString(), e.Message);
            }
        }

        #endregion
    }
}
