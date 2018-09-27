using System.Diagnostics;
            string[] headerLines = header.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    sb.Append(pppLine).Append('\n');
                    sb.Append(line).Append('\n');
            var selectedChunks = FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreamble, fileContentEncoding);
            string body = ToIndexPatch(selectedChunks, isIndex: false, isWholeFile: true);

            if (body == null)
                return null;
            const string fileMode = "100000"; // given fake mode to satisfy patch format, git will override this
            var header = new StringBuilder();
            header.Append("diff --git a/").Append(newFileName).Append(" b/").Append(newFileName).Append('\n');
            if (!reset)
                header.Append("new file mode ").Append(fileMode).Append('\n');
            header.Append("index 0000000..0000000\n");

            if (reset)
                header.Append("--- a/").Append(newFileName).Append('\n');
                header.Append("--- /dev/null").Append('\n');

            header.Append("+++ b/").Append(newFileName).Append('\n');

            return GetPatchBytes(header.ToString(), body, fileContentEncoding);
            return new[] { Chunk.FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreamble, fileContentEncoding) };
    [DebuggerDisplay("{" + nameof(Text) + "}")]
            bool selectedLastRemovedLine = false;
            bool selectedLastAddedLine = false;
                selectedLastAddedLine = removedLine.Selected;
            foreach (var addedLine in AddedLines)
                selectedLastRemovedLine = addedLine.Selected;
            if (PostContext.Count == 0 && (selectedLastRemovedLine || !isIndex))
            if (PostContext.Count == 0 && (selectedLastAddedLine || isIndex || isWholeFile))