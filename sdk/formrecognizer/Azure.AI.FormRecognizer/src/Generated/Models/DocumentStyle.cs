// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object representing observed text styles. </summary>
    public partial class DocumentStyle
    {
        /// <summary> Initializes a new instance of DocumentStyle. </summary>
        /// <param name="spans"> Location of the text elements in the concatenated content the style applies to. </param>
        /// <param name="confidence"> Confidence of correctly identifying the style. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="spans"/> is null. </exception>
        internal DocumentStyle(IEnumerable<DocumentSpan> spans, float confidence)
        {
            Argument.AssertNotNull(spans, nameof(spans));

            Spans = spans.ToList();
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of DocumentStyle. </summary>
        /// <param name="isHandwritten"> Is content handwritten?. </param>
        /// <param name="similarFontFamily"> Visually most similar font from among the set of supported font families, with fallback fonts following CSS convention (ex. 'Arial, sans-serif'). </param>
        /// <param name="fontStyle"> Font style. </param>
        /// <param name="fontWeight"> Font weight. </param>
        /// <param name="color"> Foreground color in #rrggbb hexadecimal format. </param>
        /// <param name="backgroundColor"> Background color in #rrggbb hexadecimal format.. </param>
        /// <param name="spans"> Location of the text elements in the concatenated content the style applies to. </param>
        /// <param name="confidence"> Confidence of correctly identifying the style. </param>
        internal DocumentStyle(bool? isHandwritten, string similarFontFamily, DocumentFontStyle? fontStyle, DocumentFontWeight? fontWeight, string color, string backgroundColor, IReadOnlyList<DocumentSpan> spans, float confidence)
        {
            IsHandwritten = isHandwritten;
            SimilarFontFamily = similarFontFamily;
            FontStyle = fontStyle;
            FontWeight = fontWeight;
            Color = color;
            BackgroundColor = backgroundColor;
            Spans = spans;
            Confidence = confidence;
        }

        /// <summary> Is content handwritten?. </summary>
        public bool? IsHandwritten { get; }
        /// <summary> Visually most similar font from among the set of supported font families, with fallback fonts following CSS convention (ex. 'Arial, sans-serif'). </summary>
        public string SimilarFontFamily { get; }
        /// <summary> Font style. </summary>
        public DocumentFontStyle? FontStyle { get; }
        /// <summary> Font weight. </summary>
        public DocumentFontWeight? FontWeight { get; }
        /// <summary> Foreground color in #rrggbb hexadecimal format. </summary>
        public string Color { get; }
        /// <summary> Background color in #rrggbb hexadecimal format.. </summary>
        public string BackgroundColor { get; }
        /// <summary> Location of the text elements in the concatenated content the style applies to. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Confidence of correctly identifying the style. </summary>
        public float Confidence { get; }
    }
}
