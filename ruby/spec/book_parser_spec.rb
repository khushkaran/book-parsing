require "spec_helper"
require "book_parser"

describe BookParser do

  let(:parser) { BookParser.new("../text.txt")}

  it "can be initialised with text file" do
    expect(parser.book).not_to be_nil
  end
  
end