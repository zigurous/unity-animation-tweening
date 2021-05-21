﻿using UnityEngine;

namespace Zigurous.Animation.Tweening
{
    public static class MaterialTweens
    {
        public static Tween TweenColor(this Material material, Color to, float duration) =>
            Tweener.To(getter: () => material.color,
                       setter: color => material.color = color,
                       to, duration).SetTarget(material);

        public static Tween TweenAlpha(this Material material, float to, float duration) =>
            Tweener.To(getter: () => material.color.a,
                       setter: alpha => material.color = new Color(material.color.r, material.color.g, material.color.b, alpha),
                       to, duration).SetTarget(material);

        public static Tween TweenMainTextureScale(this Material material, Vector2 to, float duration) =>
            Tweener.To(getter: () => material.mainTextureScale,
                       setter: mainTextureScale => material.mainTextureScale = mainTextureScale,
                       to, duration).SetTarget(material);

        public static Tween TweenMainTextureOffset(this Material material, Vector2 to, float duration) =>
            Tweener.To(getter: () => material.mainTextureOffset,
                       setter: mainTextureOffset => material.mainTextureOffset = mainTextureOffset,
                       to, duration).SetTarget(material);

    }

}