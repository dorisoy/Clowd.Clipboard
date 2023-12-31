﻿namespace Clowd.Clipboard;

/// <summary>
/// The base class for creating a static clipboard helper.
/// </summary>
[SupportedOSPlatform("windows")]
public class ClipboardStaticBase<THandle, TBitmap>
    where THandle : ClipboardHandle, IClipboardHandlePlatform<TBitmap>, new()
    where TBitmap : class
{
    /// <summary>
    /// Do not use.
    /// </summary>
    protected ClipboardStaticBase()
    {
    }

    /// <summary>
    /// Opens a clipboard handle. You are responsible for disposing of it when done.
    /// </summary>
    public static THandle Open()
    {
        var ch = new THandle();
        ch.Open();
        return ch;
    }

    /// <summary>
    /// Opens a clipboard handle. You are responsible for disposing of it when done.
    /// </summary>
    public static async Task<THandle> OpenAsync()
    {
        var ch = new THandle();
        await ch.OpenAsync().ConfigureAwait(false);
        return ch;
    }

    /// <inheritdoc cref="ClipboardHandle.Empty"/>
    public static void Empty()
    {
        using var ch = Open();
        ch.Empty();
    }

    /// <inheritdoc cref="ClipboardHandle.Empty"/>
    public static async Task EmptyAsync()
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        ch.Empty();
    }

    /// <inheritdoc cref="ClipboardHandle.GetText"/>
    public static string GetText()
    {
        using var ch = Open();
        return ch.GetText();
    }

    /// <inheritdoc cref="ClipboardHandle.GetText"/>
    public static async Task<string> GetTextAsync()
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        return ch.GetText();
    }

    /// <inheritdoc cref="ClipboardHandle.SetText"/>
    public static void SetText(string text)
    {
        using var ch = Open();
        ch.SetText(text);
    }

    /// <inheritdoc cref="ClipboardHandle.SetText"/>
    public static async Task SetTextAsync(string text)
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        ch.SetText(text);
    }

    /// <inheritdoc cref="IClipboardHandlePlatform{TBitmap}.SetImage"/>
    public static void SetImage(TBitmap bitmap)
    {
        using var ch = Open();
        ch.SetImage(bitmap);
    }

    /// <inheritdoc cref="IClipboardHandlePlatform{TBitmap}.SetImage"/>
    public static async Task SetImageAsync(TBitmap bitmap)
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        ch.SetImage(bitmap);
    }

    /// <inheritdoc cref="IClipboardHandlePlatform{TBitmap}.GetImage"/>
    public static TBitmap GetImage()
    {
        using var ch = Open();
        return ch.GetImage();
    }

    /// <inheritdoc cref="IClipboardHandlePlatform{TBitmap}.GetImage"/>
    public static async Task<TBitmap> GetImageAsync()
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        return ch.GetImage();
    }

    /// <inheritdoc cref="ClipboardHandle.GetFileDropList"/>
    public static string[] GetFileDropList()
    {
        using var ch = Open();
        return ch.GetFileDropList();
    }

    /// <inheritdoc cref="ClipboardHandle.GetFileDropList"/>
    public static async Task<string[]> GetFileDropListAsync()
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        return ch.GetFileDropList();
    }

    /// <inheritdoc cref="ClipboardHandle.SetFileDropList"/>
    public static void SetFileDropList(string[] files)
    {
        using var ch = Open();
        ch.SetFileDropList(files);
    }

    /// <inheritdoc cref="ClipboardHandle.SetFileDropList"/>
    public static async Task SetFileDropListAsync(string[] files)
    {
        using var ch = await OpenAsync().ConfigureAwait(false);
        ch.SetFileDropList(files);
    }
}
