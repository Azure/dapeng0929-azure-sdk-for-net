// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> On every file uploads, Batch service writes two log files to the compute node, 'fileuploadout.txt' and 'fileuploaderr.txt'. These log files are used to learn more about a specific failure. </summary>
    public partial class OutputFile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OutputFile"/>. </summary>
        /// <param name="filePattern"> A pattern indicating which file(s) to upload. Both relative and absolute paths are supported. Relative paths are relative to the Task working directory. The following wildcards are supported: * matches 0 or more characters (for example pattern abc* would match abc or abcdef), ** matches any directory, ? matches any single character, [abc] matches one character in the brackets, and [a-c] matches one character in the range. Brackets can include a negation to match any character not specified (for example [!abc] matches any character but a, b, or c). If a file name starts with "." it is ignored by default but may be matched by specifying it explicitly (for example *.gif will not match .a.gif, but .*.gif will). A simple example: **\*.txt matches any file that does not start in '.' and ends with .txt in the Task working directory or any subdirectory. If the filename contains a wildcard character it can be escaped using brackets (for example abc[*] would match a file named abc*). Note that both \ and / are treated as directory separators on Windows, but only / is on Linux. Environment variables (%var% on Windows or $var on Linux) are expanded prior to the pattern being applied. </param>
        /// <param name="destination"> The destination for the output file(s). </param>
        /// <param name="uploadOptions"> Additional options for the upload operation, including under what conditions to perform the upload. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filePattern"/>, <paramref name="destination"/> or <paramref name="uploadOptions"/> is null. </exception>
        public OutputFile(string filePattern, OutputFileDestination destination, OutputFileUploadConfig uploadOptions)
        {
            Argument.AssertNotNull(filePattern, nameof(filePattern));
            Argument.AssertNotNull(destination, nameof(destination));
            Argument.AssertNotNull(uploadOptions, nameof(uploadOptions));

            FilePattern = filePattern;
            Destination = destination;
            UploadOptions = uploadOptions;
        }

        /// <summary> Initializes a new instance of <see cref="OutputFile"/>. </summary>
        /// <param name="filePattern"> A pattern indicating which file(s) to upload. Both relative and absolute paths are supported. Relative paths are relative to the Task working directory. The following wildcards are supported: * matches 0 or more characters (for example pattern abc* would match abc or abcdef), ** matches any directory, ? matches any single character, [abc] matches one character in the brackets, and [a-c] matches one character in the range. Brackets can include a negation to match any character not specified (for example [!abc] matches any character but a, b, or c). If a file name starts with "." it is ignored by default but may be matched by specifying it explicitly (for example *.gif will not match .a.gif, but .*.gif will). A simple example: **\*.txt matches any file that does not start in '.' and ends with .txt in the Task working directory or any subdirectory. If the filename contains a wildcard character it can be escaped using brackets (for example abc[*] would match a file named abc*). Note that both \ and / are treated as directory separators on Windows, but only / is on Linux. Environment variables (%var% on Windows or $var on Linux) are expanded prior to the pattern being applied. </param>
        /// <param name="destination"> The destination for the output file(s). </param>
        /// <param name="uploadOptions"> Additional options for the upload operation, including under what conditions to perform the upload. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutputFile(string filePattern, OutputFileDestination destination, OutputFileUploadConfig uploadOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilePattern = filePattern;
            Destination = destination;
            UploadOptions = uploadOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OutputFile"/> for deserialization. </summary>
        internal OutputFile()
        {
        }

        /// <summary> A pattern indicating which file(s) to upload. Both relative and absolute paths are supported. Relative paths are relative to the Task working directory. The following wildcards are supported: * matches 0 or more characters (for example pattern abc* would match abc or abcdef), ** matches any directory, ? matches any single character, [abc] matches one character in the brackets, and [a-c] matches one character in the range. Brackets can include a negation to match any character not specified (for example [!abc] matches any character but a, b, or c). If a file name starts with "." it is ignored by default but may be matched by specifying it explicitly (for example *.gif will not match .a.gif, but .*.gif will). A simple example: **\*.txt matches any file that does not start in '.' and ends with .txt in the Task working directory or any subdirectory. If the filename contains a wildcard character it can be escaped using brackets (for example abc[*] would match a file named abc*). Note that both \ and / are treated as directory separators on Windows, but only / is on Linux. Environment variables (%var% on Windows or $var on Linux) are expanded prior to the pattern being applied. </summary>
        public string FilePattern { get; set; }
        /// <summary> The destination for the output file(s). </summary>
        public OutputFileDestination Destination { get; set; }
        /// <summary> Additional options for the upload operation, including under what conditions to perform the upload. </summary>
        public OutputFileUploadConfig UploadOptions { get; set; }
    }
}
