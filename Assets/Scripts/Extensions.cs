using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This static class provides extension methods for different Unity types to enhance their functionality.
/// </summary>
public static class Extensions
{
    #region VECTOR
    /// <summary>
    /// Modifies a Vector3's x, y, and/or z components while retaining original values for any unspecified component.
    /// </summary>
    /// <param name="vector">The Vector3 to modify.</param>
    /// <param name="x">Optional new value for the x component.</param>
    /// <param name="y">Optional new value for the y component.</param>
    /// <param name="z">Optional new value for the z component.</param>
    /// <returns>A new Vector3 with modified values.</returns>
    public static Vector3 With(this Vector3 vector, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? vector.x, y ?? vector.y, z ?? vector.z);
    }

    /// <summary>
    /// Adds specified values to the x, y, and/or z components of a Vector3. Defaults to adding 0 if no value is provided.
    /// </summary>
    /// <param name="vector">The Vector3 to be added to.</param>
    /// <param name="x">Optional value to add to the x component.</param>
    /// <param name="y">Optional value to add to the y component.</param>
    /// <param name="z">Optional value to add to the z component.</param>
    /// <returns>A new Vector3 with added values.</returns>
    public static Vector3 Add(this Vector3 vector, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(vector.x + (x ?? 0), vector.y + (y ?? 0), vector.z + (z ?? 0));
    }
    #endregion

    #region SPRITE_RENDERER
    /// <summary>
    /// Sets the alpha (transparency) of the color of a SpriteRenderer.
    /// </summary>
    /// <param name="spriteRenderer">The SpriteRenderer to modify.</param>
    /// <param name="alpha">The alpha value to set.</param>
    public static void SetAlpha(this SpriteRenderer spriteRenderer, float alpha)
    {
        Color color = spriteRenderer.color;
        color.a = alpha;
        spriteRenderer.color = color;
    }
    #endregion

    #region TRANSFORM
    /// <summary>
    /// Resets the local position, rotation, and scale of a Transform to default values.
    /// </summary>
    /// <param name="transform">The Transform to reset.</param>
    public static void LocalReset(this Transform transform)
    {
        transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        transform.localScale = Vector3.one;
    }

    /// <summary>
    /// Resets the global position, rotation, and scale of a Transform to default values.
    /// </summary>
    /// <param name="transform">The Transform to reset.</param>
    public static void GlobalReset(this Transform transform)
    {
        transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        transform.localScale = Vector3.one;
    }

    /// <summary>
    /// Sets the global position of a Transform.
    /// </summary>
    /// <param name="transform">The Transform to modify.</param>
    /// <param name="x">The x-coordinate of the new position.</param>
    /// <param name="y">The y-coordinate of the new position.</param>
    /// <param name="z">The z-coordinate of the new position.</param>
    public static void SetPosition(this Transform transform, float? x = null, float? y = null, float? z = null)
    {
        transform.position = new Vector3(x ?? transform.position.x, y ?? transform.position.y, z ?? transform.position.z);
    }

    /// <summary>
    /// Sets the local position of a Transform.
    /// </summary>
    /// <param name="transform">The Transform to modify.</param>
    /// <param name="x">The x-coordinate of the new position.</param>
    /// <param name="y">The y-coordinate of the new position.</param>
    /// <param name="z">The z-coordinate of the new position.</param>
    public static void SetLocalPosition(this Transform transform, float x, float y, float z)
    {
        transform.localPosition = new Vector3(x, y, z);
    }
    #endregion

    #region RIGIDBODY_2D
    /// <summary>
    /// Freezes the movement and rotation of a 2D Rigidbody.
    /// </summary>
    /// <param name="rigidbody2D">The Rigidbody2D to freeze.</param>
    public static void Freeze(this Rigidbody2D rigidbody2D)
    {
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.angularVelocity = 0;
        rigidbody2D.isKinematic = true;
    }
    #endregion

    #region RIGIDBODY
    /// <summary>
    /// Freezes the movement and rotation of a 3D Rigidbody.
    /// </summary>
    /// <param name="rigidbody">The Rigidbody to freeze.</param>
    public static void Freeze(this Rigidbody rigidbody)
    {
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.isKinematic = true;
    }
    #endregion

    #region STRING
    /// <summary>
    /// Checks if a string is null or empty.
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <returns>True if the string is null or empty, otherwise false.</returns>
    public static bool IsNullOrEmpty(this string value)
    {
        return string.IsNullOrEmpty(value);
    }
    #endregion

    #region UI
    /// <summary>
    /// Sets the alpha (transparency) of the color of any UI.
    /// </summary>
    /// <param name="graphic">The Graphic to modify.</param>
    /// <param name="alpha">The alpha value to set.</param>
    public static void SetAlpha(this UnityEngine.UI.Graphic graphic, float alpha)
    {
        Color color = graphic.color;
        color.a = alpha;
        graphic.color = color;
    }
    #endregion

    #region LIST
    /// <summary>
    /// Selects a random element from a list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="list">The list to select from.</param>
    /// <returns>A random element from the list.</returns>
    public static T Rand<T>(this IList<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
    #endregion
}