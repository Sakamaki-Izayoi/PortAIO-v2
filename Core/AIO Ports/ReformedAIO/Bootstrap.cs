using EloBuddy; 
 using LeagueSharp.Common; 
 namespace ReformedAIO
{
    #region Using Directives

    using System.Collections.Generic;

    using LeagueSharp;

    using RethoughtLib.Bootstraps.Abstract_Classes;
    using RethoughtLib.Bootstraps.Implementations;

    #endregion

    internal class Bootstrap : LeagueSharpMultiBootstrap
    {
        #region Constructors and Destructors

        public Bootstrap(IEnumerable<LoadableBase> modules, IEnumerable<string> additionalStrings = null) : base(modules, additionalStrings)
        {
            Chat.Print("<b><font color=\"#FFFFFF\">[</font></b><b><font color=\"#00e5e5\">Reformed AIO</font></b><b><font color=\"#FFFFFF\">]</font></b><b><font color=\"#FFFFFF\"> - Loaded!</font></b>");
        }

        #endregion
    }
}