// This file is part of the DSharpPlus project.
//
// Copyright (c) 2015 Mike Santiago
// Copyright (c) 2016-2023 DSharpPlus Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using Newtonsoft.Json;

namespace DSharpPlus.Entities
{
    /// <summary>
    /// Represents a discord role tags.
    /// </summary>
    public class DiscordRoleTags
    {
        /// <summary>
        /// Gets the id of the bot this role belongs to.
        /// </summary>
        [JsonProperty("bot_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? BotId { get; internal set; }

        /// <summary>
        /// Gets the id of the integration this role belongs to.
        /// </summary>
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? IntegrationId { get; internal set; }

        /// <summary>
        /// Gets whether this is the guild's premium subscriber role.
        /// </summary>
        [JsonIgnore]
        public bool IsPremiumSubscriber
            => this._premiumSubscriber.HasValue && this._premiumSubscriber.Value is null;

        [JsonProperty("premium_subscriber", NullValueHandling = NullValueHandling.Include)]
        internal Optional<bool?> _premiumSubscriber = false;

    }
}
