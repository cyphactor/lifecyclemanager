<?cs
# Copyright 2007-2008 Lifecycle Manager Development Team
# http://www.insearchofartifice.com/lifecyclemanager/wiki/DevTeam
#
# This file is part of Lifecycle Manager.
#
# Lifecycle Manager is free software: you can redistribute it and/or
# modify it under the terms of the GNU General Public License as
# published by the Free Software Foundation, either version 3 of the
# License, or (at your option) any later version.
#
# Lifecycle Manager is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
# General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with Lifecycle Manager.  If not, see
# <http://www.gnu.org/licenses/>.
?>

<?xml version="1.0"?>
<!-- RSS generated by Trac v<?cs var:trac.version ?> on <?cs var:trac.time ?> -->
<rss version="2.0">
 <channel><?cs 
  if:project.name_encoded ?>
   <title><?cs var:project.name_encoded ?>: Requirement <?cs var:title ?></title><?cs 
  else ?>
   <title>Requirement <?cs var:title ?></title><?cs 
  /if ?>
  <link><?cs var:base_host ?><?cs var:requirement.href ?></link>
  <description><?cs var:requirement.description.formatted ?></description>
  <language>en-us</language>
  <generator>Trac v<?cs var:trac.version ?></generator><?cs
  if:chrome.logo.src ?>
   <image>
    <title><?cs var:project.name_encoded ?></title>
    <url><?cs if:!chrome.logo.src_abs ?><?cs var:base_host ?><?cs /if ?><?cs
     var:chrome.logo.src ?></url>
    <link><?cs var:base_host ?><?cs var:requirement.href ?></link>
   </image><?cs
  /if ?><?cs 
  each:change = requirement.changes ?>
   <item><?cs
    if:change.author ?><author><?cs var:change.author ?></author><?cs
    /if ?>
    <pubDate><?cs var:change.http_date ?></pubDate>
    <title><?cs var:change.title ?></title>
    <link><?cs var:base_host ?><?cs var:requirement.href ?><?cs 
     if:change.cnum ?>#comment:<?cs var:change.cnum ?><?cs
     /if ?></link>
    <guid isPermaLink="false"><?cs var:base_host ?><?cs var:requirement.href ?><?cs 
     if:change.cnum ?>#comment:<?cs var:change.cnum ?><?cs
     /if ?></guid>
    <description>
    <?cs if:len(change.fields) ?>
    &lt;ul&gt;<?cs
    each:field = change.fields ?>
    &lt;li&gt;&lt;strong&gt;<?cs name:field ?>&lt;/strong&gt; <?cs
     if:!field.old ?>set to &lt;em&gt;<?cs
      var:field.new ?>&lt;/em&gt;<?cs
     elif:field.new ?>changed from &lt;em&gt;<?cs var:field.old
      ?>&lt;/em&gt; to &lt;em&gt;<?cs
      var:field.new ?>&lt;/em&gt;.<?cs
     else ?>deleted<?cs
     /if ?>&lt;/li&gt;<?cs
    /each ?>
    &lt;/ul&gt;
    <?cs /if ?>
    <?cs var:change.comment ?>
    </description>
    <category>Requirement</category>
   </item><?cs 
  /each ?>
 </channel>
</rss>
