﻿using System.ComponentModel;

namespace Grand.Infrastructure.ModelBinding;

/// <summary>
///     Represents model attribute that specifies the display name by passed key of the locale resource
/// </summary>
public class GrandResourceDisplayNameAttribute : DisplayNameAttribute, IModelAttribute
{
    #region Ctor

    /// <summary>
    ///     Create instance of the attribute
    /// </summary>
    /// <param name="resourceKey">Key of the locale resource</param>
    public GrandResourceDisplayNameAttribute(string resourceKey) : base(resourceKey)
    {
        ResourceKey = resourceKey;
    }

    #endregion

    #region Properties

    /// <summary>
    ///     Gets or sets key of the locale resource
    /// </summary>
    public string ResourceKey { get; set; }

    /// <summary>
    ///     Gets name of the attribute
    /// </summary>
    public string Name => nameof(GrandResourceDisplayNameAttribute);

    #endregion
}